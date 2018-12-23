using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public Models.PrizeModel CreatePrize(Models.PrizeModel model)
        {
            model.id = 1;
            return model;
        }

     
    }
}
