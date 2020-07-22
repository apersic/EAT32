using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaRegistracija
{
    public class Artikl
    {
        private string nazivArtikla;
        private double cijenaArtikla;
        private int idArtikla;

        public Artikl(int id, string naziv, double cijena)
        {
            IdArtikla = id;
            NazivArtikla = naziv;
            CijenaArtikla = cijena;
        }

        public string NazivArtikla
        {
            set { nazivArtikla = value; }
            get { return nazivArtikla; }
        }

        public double CijenaArtikla
        {
            set { cijenaArtikla = value; }
            get { return cijenaArtikla; }
        }

        public int IdArtikla
        {
            set { idArtikla = value; }
            get { return idArtikla; }
        }
    }
}
