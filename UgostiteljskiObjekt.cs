using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaRegistracija
{
    public class UgostiteljskiObjekt : KorisnickiRacun
    {
        private string naziv;
        private TimeSpan radno_vrijeme_pocetak;
        private TimeSpan radno_vrijeme_kraj;

        /// <summary>
        /// Kreira novu instancu klase ugostiteljskog objekta koja predstavlja korisnicki racun ugostiteljskog objetka zajedno sa njegovim podacima. 
        /// </summary> 
        public UgostiteljskiObjekt(string username, string password, string email, string address, string phoneNumber, string placeName, TimeSpan workStart, TimeSpan workEnd)
        {
            KorisnickoIme = username;
            Lozinka = password;
            Email = email;
            Adresa = address;
            BrojTelefona = phoneNumber;
            Naziv = placeName;
            RadnoVrijemePocetak = workStart;
            RadnoVrijemeKraj = workEnd;
        }

        /// <summary>
        /// Vraća vrijednost ili postavlja novi naziv ugostiteljskog objekta. 
        /// </summary> 
        public string Naziv
        {
            set { naziv = value; }
            get { return naziv; }
        }

        /// <summary>
        /// Vraća vrijednost ili postavlja novi pocetak radnog vremena ugostiteljskog objekta. 
        /// </summary> 
        public TimeSpan RadnoVrijemePocetak
        {
            set { radno_vrijeme_pocetak = value; }
            get { return radno_vrijeme_pocetak; }
        }

        /// <summary>
        /// Vraća vrijednost ili postavlja novi kraj radnog vremena ugostiteljskog objekta. 
        /// </summary> 
        public TimeSpan RadnoVrijemeKraj
        {
            set { radno_vrijeme_kraj = value; }
            get { return radno_vrijeme_kraj; }
        }
    }
}
