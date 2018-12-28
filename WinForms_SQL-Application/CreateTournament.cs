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
    public partial class CreateTournament : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> avaliableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrize = new List<PrizeModel>();


        public CreateTournament()
        {
            InitializeComponent();
            WireUpList();
        }

        private void WireUpList()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = avaliableTeams;
            // Wstawiam nazwę z mojego modelu w "" traktuje jak zmienną
            selectTeamDropDown.DisplayMember = "TeamName";

            torunamentTeamListBox.DataSource = null;
            torunamentTeamListBox.DataSource = selectedTeams;
            torunamentTeamListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrize;
            prizesListBox.DisplayMember = "PlaceName";

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            if (t != null)
            {
                avaliableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpList();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // Wywołaj CreatePrize Winforms
            // słowo this
            CreatePrize frm = new CreatePrize(this);
            frm.Show();
            

        }

        public void PrizeComlete(PrizeModel model)
        {
            // Otrzymaj dane z powrotem z PrizeModel
            // Skorzystaj z modelu PrizeModel i dodaj go listy z Prizem:)

            selectedPrize.Add(model);
            WireUpList();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpList();
        }

        private void createNewLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeam frm = new CreateTeam(this);
            frm.Show();
        }

        private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)torunamentTeamListBox.SelectedItem;
            
            if (t!=null)
            {
                selectedTeams.Remove(t);
                avaliableTeams.Add(t);

                WireUpList();
            }
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrize.Remove(p);
                

                WireUpList();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Walidacja danych
            decimal fee = 0;

            //spróbuj przekonwertować zmienną i zapisz ją jeśi sie uda do fee
            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);
            if(!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry fee","Błędny opis",MessageBoxButtons.OK);
                // Oznacza wyjście z tego przycisku
                return;
            }
            
            
            // Utworzenie modelu tournament
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameLabel.Text;
            tm.EntryFee = fee;

            //foreach (PrizeModel prize in selectedPrize)
            //{
            //    tm.Prizes.Add(prize);
            //}

            tm.Prizes = selectedPrize;
            tm.EnteredTeams = selectedTeams;

            // Utworzenie turnieju wejście
            // Utworzenie wszystkich kwot
            // Utworzenie wszystkich drużyn
        }
    }
}
