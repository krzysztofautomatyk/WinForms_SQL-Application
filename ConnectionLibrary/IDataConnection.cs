using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary
{
    public interface IDataConnection
    {
        /// <summary>
        /// To jest kontrakt który wczytuje model ( klasę "PrizeModel" )
        /// </summary>
        /// <param name="model"> Podaje poszczególne elementy z modelu ;)</param>
        /// <returns></returns>
        Models.PrizeModel CreatePrize(Models.PrizeModel model);
    }
}
