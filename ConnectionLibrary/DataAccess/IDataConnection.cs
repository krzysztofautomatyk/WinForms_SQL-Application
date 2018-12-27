using ConnectionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary.DataAccess
{
    public interface IDataConnection
    {
        /// <summary>
        /// To jest kontrakt który wczytuje model ( klasę "PrizeModel" )
        /// </summary>
        /// <param name="model"> Podaje poszczególne elementy z modelu ;)</param>
        /// <returns></returns>
        PrizeModel CreatePrize(PrizeModel model);

        PersonModel CreatePerson(PersonModel model);

        // Twprzenie modelu drużyny
        TeamModel CreateTeam(TeamModel model);

        List<TeamModel> GetTeam_All();

        //Pobieranie danych do list 
        List<PersonModel> GetPerson_All();
    }
}
