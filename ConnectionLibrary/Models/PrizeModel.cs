using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Unikalne id wpisu z bazy danych
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Identyfikator miejsca ( 2 ozanacza drugie miejsce, itd. )
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Nazwa miejsca w formie textu ( drugie miejsce, pierwsze miejsce itd. )
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Kwota ktróre za dane miejsce się otrzymuje lub zero jesli jest nieużywana.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Procentowa wartość kwoty ( 0.5 = 50% ) lub zero jeśli jest nieużywana.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        /// <summary>
        /// Metoda pobiera wszystkie pola z textboxów jako string i konwertuje je na właściwe formaty
        /// </summary>
        /// <param name="placeName"></param>
        /// <param name="placeNumber"></param>
        /// <param name="prizeAmount"></param>
        /// <param name="prizePercentage"></param>

        public PrizeModel(string placeName, string placeNumber,string prizeAmount,string prizePercentage )
        {

            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
            
        }

    }
}
