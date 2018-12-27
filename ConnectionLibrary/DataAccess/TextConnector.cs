using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionLibrary.DataAccess.TextHelpers;
using ConnectionLibrary.Models;

namespace ConnectionLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizeFile = "PrizeModel.csv";
        private const string PeopleFile = "PersonModel.csv";
        private const string TeamFile = "TeamModel.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel(); ;

            //Znajdź najwyższe id i dodaj do niego 1
            int currenId = 1;
            if (people.Count > 0)
            {
                currenId = people.OrderByDescending(x => x.id).First().id + 1;
            }

            model.id = currenId;

            people.Add(model);

            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Wczytaj plik
            // Przekonwertuj the text to List<PrizeModel>
            // Znajdź id
            // Dodadaj nowy rekord zgodnie z modelem List<PrizeModel>
            // Przekonwertuj model na stringa
            // Zapisz plik
            
            List<PrizeModel> prizes = PrizeFile.FullFilePath().LoadFile().ConvertToPrizeModel(); 

            //Znajdź najwyższe id i dodaj do niego 1
            int currenId = 1;
            if( prizes.Count>0)
            {
                currenId= prizes.OrderByDescending(x => x.id).First().id + 1;
            }
              
            model.id = currenId;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizeFile);

            return model;

        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);

            int currenId = 1;
            if (teams.Count > 0)
            {
                currenId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currenId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);

            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<TeamModel> GetTeam_All()
        {
            throw new NotImplementedException();
        }
    }
}
