using ConnectionLibrary;
using ConnectionLibrary.DataAccess;
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
    public partial class CreatePrize : Form
    {
        public CreatePrize()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                    PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    PrizeAmountValue.Text,
                    prizePercentageValue.Text);


                    GlobalConfig.Connection.CreatePrize(model);

                
                    placeNameValue.Text = "";
                    placeNumberValue.Text = "";
                    PrizeAmountValue.Text = "0";
                    prizePercentageValue.Text = "0";


            }
            else
            {
                MessageBox.Show("Źle wypełniełeś textBoxy");
            }
        }
        
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            // Jeśli mój textbox da się przekonwertować na liczbę zwróć true i przekaż tą wartość do "placeNumber"
            bool placeNumberVaildNumber = int.TryParse(placeNumberValue.Text,out placeNumber);

            if(!placeNumberVaildNumber)
            {
                output = false;
            }

            if(placeNumber <1)
            {
                output = false;
            }
            //Jeśli w swoim textBoxie nie ma żadnego tekstu to ustaw false
            if(placeNameValue.Text.Length==0)
            {
                output = false;
            }

            decimal priceAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out priceAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid== false)
            {
                output = false;
            }

            if (priceAmount <=00 && prizePercentage<=0)
            {
                output = false;
            }

            // Procentowa kwota musi być większa od 0% a mniejsza niż 100%

            if (prizePercentage<0 || prizePercentage>100)
            {
                output = false;
            }

            return output;
        }
    }
}
