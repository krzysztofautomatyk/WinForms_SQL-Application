using ConnectionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ConnectionLibrary.DataAccess
{

    public class SqlConnector : IDataConnection
    {
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("turnaments")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellPhoneNumber", model.CellPhoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // Insert/update/exeute
                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");
                return model;
            }
        }
        //TODO - dorób metode zachowującą kwotę w bazie danych
        /// <summary>
        /// Zapisuje nową kwotę w bazie danych
        /// </summary>
        /// <param name="model">Informacje o kwocie</param>
        /// <returns>Informacje z kwotą przypisaną do unikalnego numeru id z bazy</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("turnaments")))
            {
                //var output = connection.Query<Person>($"select * from People where LastName = '{ lastName }'").ToList();
                //var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                //return output;

             //   @PlaceNumber int,
             //   @PlaceName NVARCHAR(50),
	            //@PrizeAmount MONEY,
             //   @PrizePercentage FLOAT,
	            //@id int= 0 output

                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // Insert/update/exeute
                connection.Execute("dbo.spPrizes_Insert", p,commandType:CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");
                return model;


            }
        }

        public List<PersonModel> GetPerson_All()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("turnaments")))
            {
            }

            
              
        }
    }
}
