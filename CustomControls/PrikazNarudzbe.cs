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
    public partial class PrikazNarudzbe : UserControl
    {
        BazaPodataka baza = new BazaPodataka();
        private dbNarudžba odabranaNarudzba;

        public PrikazNarudzbe(dbNarudžba narudzba)
        {
            InitializeComponent();
            odabranaNarudzba = narudzba;
            OznakaNarudzbe = narudzba.id_narudzbe.ToString();
        }

        public string OznakaNarudzbe
        {
            set { uiOznakaNarudzba.Text = value; }
            get { return uiOznakaNarudzba.Text; }
        }

        private void uiBtnProsiri_Click(object sender, EventArgs e)
        {
            TogglePrikaziStavke();
        }

        private void uiOznakaNarudzba_Click(object sender, EventArgs e)
        {
            TogglePrikaziStavke();
        }

        private void uiOznakaKontrola_Click(object sender, EventArgs e)
        {
            TogglePrikaziStavke();
        }

        public void TogglePrikaziStavke()
        {
            if (uiPopisStavki.Visible == false)
            {
                uiPopisStavki.Visible = true;
                this.Size = new Size(454, 113);
            }
            else
            {
                uiPopisStavki.Visible = false;
                this.Size = new Size(454, 46);
            }
        }

        public void DohvatiStavkeNarudzbe()
        {
            BindingList<dbStavkaNarudzbe> listaStavki = null;
            listaStavki = baza.DohvatiStavkeNarudzbe(odabranaNarudzba.id_narudzbe);

            if (listaStavki.Count != 0)
            {
                foreach (var stavka in listaStavki)
                {
                    dbArtikl artiklStavke = baza.DohvatiArtikl(stavka.artikl_id);
                    int cijenaStavke = int.Parse(artiklStavke.cijena) * stavka.kolicina;
                    uiPopisStavki.AppendText(stavka.kolicina + " x " + artiklStavke.naziv + " ("+ cijenaStavke.ToString() + " HRK)" + Environment.NewLine);
                }

                uiPopisStavki.AppendText("------------------------------------" + Environment.NewLine);
                int ukupanIznos = baza.IzracunajIznosNarudzbe(odabranaNarudzba.id_narudzbe);
                uiPopisStavki.AppendText("Ukupno: " + ukupanIznos.ToString() + " HRK");
            }
        }

        private void PrikazNarudzbe_Load(object sender, EventArgs e)
        {
            DohvatiStavkeNarudzbe();
        }
    }
}
