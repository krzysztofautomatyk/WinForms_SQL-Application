using ConnectionLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        /// <summary>
        /// Ustawiamy komunikacje naszej aplikacji z bazą danych i/lub systemem plików
        /// </summary>
        /// <param name="database">Jeśli chcesz używać bazy danych -> True</param>
        /// <param name="textFiles">Jeśli chcesz używać systemu plików ->True</param>
        public static void InitializeConnections ( bool database , bool textFiles)
        {
            if (database)
            {
                //TODO - coś trzeba tu dopisać
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
                ///TODO - coś dodaj
            }
        }
    }
}
