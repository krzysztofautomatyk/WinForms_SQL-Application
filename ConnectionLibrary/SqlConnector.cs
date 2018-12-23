using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary
{

    public class SqlConnector : IDataConnection
    {
        //TODO - dorób metode zachowującą kwotę w bazie danych
        /// <summary>
        /// Zapisuje nową kwotę w bazie danych
        /// </summary>
        /// <param name="model">Informacje o kwocie</param>
        /// <returns>Informacje z kwotą przypisaną do unikalnego numeru id z bazy</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
