using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaRegistracija
{
    class StavkaArtikla
    {
        private int idArtikla;
        private int kolicina;

        public StavkaArtikla(int artikl_id)
        {
            IdArtikla = artikl_id;
            kolicina = 1;
        }

        public int IdArtikla
        {
            set { idArtikla = value; }
            get { return idArtikla; }
        }

        public int Kolicina
        {
            set { kolicina = value; }
            get { return kolicina; }
        }
    }
}
