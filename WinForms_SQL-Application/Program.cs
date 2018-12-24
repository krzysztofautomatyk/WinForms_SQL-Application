using ConnectionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SQL_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize the database connections
            ConnectionLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);

            //Application.Run(new TorunamentDashboard());
            Application.Run(new CreateTeam());
        }
    }
}
