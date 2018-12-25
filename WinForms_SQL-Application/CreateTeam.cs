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
        private List<PersonModel> availbleTeamMeambers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMeambers = new List<PersonModel>();

        public CreateTeam()
        {
            InitializeComponent();

            //CreateSimpleDemoData();

            WireUpList();
        }

        private void CreateSimpleDemoData()
        {
            availbleTeamMeambers.Add(new PersonModel { FirstName = "Kris", LastName = "Nowak" });
            availbleTeamMeambers.Add(new PersonModel { FirstName = "Super", LastName = "Kris" });
            availbleTeamMeambers.Add(new PersonModel { FirstName = "Tim", LastName = "Smith" });

            selectedTeamMeambers.Add(new PersonModel { FirstName = "Anna", LastName = "Nowak" });
            selectedTeamMeambers.Add(new PersonModel { FirstName = "Jan", LastName = "Kowalski" });
        }

        private void WireUpList()
        {
            selectTeamMemberDropDown.DataSource = availbleTeamMeambers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

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
    }
}
