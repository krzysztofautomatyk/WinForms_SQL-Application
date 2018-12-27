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
    public partial class CreateTeam : Form
    {
        private List<PersonModel> availbleTeamMeambers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMeambers = new List<PersonModel>();
        private ITeamRequester callingForm;
        
        public CreateTeam(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
            //CreateSimpleDemoData();

            WireUpList();
        }


        #region CreateSimpleDemoDate
        private void CreateSimpleDemoData()
        {
            availbleTeamMeambers.Add(new PersonModel { FirstName = "Kris", LastName = "Nowak" });
            availbleTeamMeambers.Add(new PersonModel { FirstName = "Super", LastName = "Kris" });
            availbleTeamMeambers.Add(new PersonModel { FirstName = "Tim", LastName = "Smith" });

            selectedTeamMeambers.Add(new PersonModel { FirstName = "Anna", LastName = "Nowak" });
            selectedTeamMeambers.Add(new PersonModel { FirstName = "Jan", LastName = "Kowalski" });
        }
        #endregion

        private void WireUpList()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availbleTeamMeambers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListtBox.DataSource = null;

            teamMembersListtBox.DataSource = selectedTeamMeambers;
            teamMembersListtBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellPhoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);
                
                // dodaje nowa osobę i odświeżam liste
                selectedTeamMeambers.Add(p);
                WireUpList();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola!");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void CreateTeam_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Metoda przenosi wybrany element z ComboBoxa do listboxa  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMemberButton_Click(object sender, EventArgs e)
        {
            
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availbleTeamMeambers.Remove(p);
                selectedTeamMeambers.Add(p);

                WireUpList();
            }
        }


        /// <summary>
        /// Przycisk usuwa dane z listy i dodaje je z powrotem do ComboBoxa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeSelectedTeamMembersButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListtBox.SelectedItem;
            if (p !=null)
            {
                selectedTeamMeambers.Remove(p);
                availbleTeamMeambers.Add(p);

                WireUpList();
            }
            
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = TeamNameValue.Text;
            t.TeamMembers = selectedTeamMeambers;

            GlobalConfig.Connection.CreateTeam(t);

            // dodaje nowy obiekt i zwracam go do winfromsa głownego

            callingForm.TeamComplete(t);
            this.Close();
        }
    }
}
