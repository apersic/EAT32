using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaRegistracija
{
    public class ObicniKorisnik : KorisnickiRacun
    {
        private string ime;
        private string prezime;

        /// <summary>
        /// Kreira novu instancu klase obicnog korisnika koja predstavlja korisnicki racun obicnog korisnika zajedno sa njegovim podacima. 
        /// </summary> 
        public ObicniKorisnik(string username, string password, string email, string address, string phoneNumber, string name, string surname)
        {
            KorisnickoIme = username;
            Lozinka = password;
            Email = email;
            Adresa = address;
            BrojTelefona = phoneNumber;
            Ime = name;
            Prezime = surname;
        }

        /// <summary>
        /// Vraća vrijednost ili postavlja novo ime obicnog korisnika. 
        /// </summary> 
        public string Ime
        {
            set { ime = value; }
            get { return ime; }
        }

        /// <summary>
        /// Vraća vrijednost ili postavlja novo prezime obicnog korisnika. 
        /// </summary> 
        public string Prezime
        {
            set { prezime = value; }
            get { return prezime; }
        }
    }
}
