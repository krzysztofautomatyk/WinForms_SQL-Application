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
        /// <summary>
        /// Nazwa bazy danych z którą się łącze
        /// </summary>
        private const string db = "turnaments";
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
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

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // Insert/update/exeute
                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");

                foreach (PersonModel tm in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", tm.id);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                    
                }

                return model;
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                // pobiera dane z tabeli w formie listy jako model PersonModel :) 
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();

            }
            return output;

            
              
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                // pobiera dane z tabeli w formie listy jako model PersonModel :) 
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();
                //spTeamMembers_GetByTeam

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p ,commandType: CommandType.StoredProcedure).ToList();
                }

            }
            return output;

        }
    }
}









