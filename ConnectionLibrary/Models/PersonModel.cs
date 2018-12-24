using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Unikalne id wpisu z bazy danych
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Imie
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Adres email
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Telefon kontaktowy
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}
