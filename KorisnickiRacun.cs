using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaRegistracija
{
    public class KorisnickiRacun
    {
        private int idRacuna;
        private string korisnickoIme;
        private string lozinka;
        private string email;
        private string adresa;
        private string brojTelefona;

        /// <summary>
        /// Vraća vrijednost ili postavlja novu vrijednost ID-a korisnickog racuna. 
        /// </summary> 
        public int IDRacuna
        {
            set { idRacuna = value; }
            get { return idRacuna; }
        }

        /// <summary>
        /// Vraća vrijednost ili postavlja novo korisnicko ime korisnickog racuna. 
        /// </summary> 
        public string KorisnickoIme
        {
            set { korisnickoIme = value; }
            get { return korisnickoIme; }
        }

        /// <summary>
        /// Vraća vrijednost ili postavlja novu lozinku korisnickog racuna. 
        /// </summary> 
        public string Lozinka
        {
            set { lozinka = value; }
            get { return lozinka; }
        }

        /// <summary>
        /// Vraća vrijednost ili postavlja novu vrijednost atributa email-a korisnickog racuna. 
        /// </summary> 
        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        /// <summary>
        /// Vraća vrijednost ili postavlja novu vrijednost adrese korisnickog racuna. 
        /// </summary> 
        public string Adresa
        {
            set { adresa = value; }
            get { return adresa; }
        }

        /// <summary>
        /// Vraća vrijednost ili postavlja novu vrijednost broja telefona korisnickog racuna. 
        /// </summary> 
        public string BrojTelefona
        {
            set { brojTelefona = value; }
            get { return brojTelefona; }
        }
    }
}
