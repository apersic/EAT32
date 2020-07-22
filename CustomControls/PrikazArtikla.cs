using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaRegistracija.CustomControls
{
    public partial class PrikazArtikla : UserControl
    {
        dbArtikl ovajArtikl = null;
        BazaPodataka baza = new BazaPodataka();

        public PrikazArtikla(dbArtikl artikl)
        {
            InitializeComponent();
            ovajArtikl = artikl;
            NazivArtikla = ovajArtikl.naziv;
            CijenaArtikla = ovajArtikl.cijena + " HRK";
        }

        public string NazivArtikla
        {
            set { uiNazivArtikla.Text = value; }
            get { return uiNazivArtikla.Text; }
        }

        public string CijenaArtikla
        {
            set { uiCijenaArtikla.Text = value; }
            get { return uiCijenaArtikla.Text; }
        }

        private void uiIzbrisiArtikl_Click(object sender, EventArgs e)
        {
            if (baza.IzbrisiArtikl(ovajArtikl.id_artikla) == false)
            {
                Notifikacija novaNotifikacija = new Notifikacija("Uspjesno obrisano", "Artikl je uspjesno obrisan!", "potvrda");
                novaNotifikacija.ShowDialog();
            }
        }
    }
}
