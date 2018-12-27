using ConnectionLibrary;
using ConnectionLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SQL_Application
{
    public partial class CreateTournament : Form
    {
        List<TeamModel> avaliableTeams = GlobalConfig.Connection.GetTeam_All();

        public CreateTournament()
        {
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            selectTeamDropDown.DataSource = avaliableTeams;
            // Wstawiam nazwę z mojego modelu w "" traktuje jak zmienną
            selectTeamDropDown.DisplayMember = "TeamName";
        }

    }
}
