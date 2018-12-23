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
    }
}
