using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaRegistracija
{
    public partial class NoviArtikl : Form
    {
        dbPonuda odabranaPonuda;
        BazaPodataka baza = new BazaPodataka();

        public NoviArtikl(dbPonuda ponuda)
        {
            InitializeComponent();
            odabranaPonuda = ponuda;
        }

        private void uiZatvoriProzor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSpremi_Click(object sender, EventArgs e)
        {
            int cijenaArtikla;

            if (!int.TryParse(uiUnosCijena.Text, out cijenaArtikla))
            {
                return;
            }

            if (uiUnosNaziv.Text != "")
            {
                baza.UpisiArtikl(odabranaPonuda.id_ponude, uiUnosNaziv.Text, cijenaArtikla);
                Notifikacija formNovaNotifikacija = new Notifikacija("Uspjesno uneseno", "Artikl je uspjesno unesen!", "potvrda");
                formNovaNotifikacija.ShowDialog();

                UgostiteljskiObjekt ovajObjekt = baza.DohvatiUgostiteljskiObjekt(odabranaPonuda.ugostiteljski_obrt_id);
                baza.ObavijestiPretplatnike(odabranaPonuda.ugostiteljski_obrt_id, $"Novo u ponudi u ugostiteljskom objektu {ovajObjekt.Naziv}! {uiUnosNaziv.Text} za samo {uiUnosCijena.Text} kuna!");
                this.Close();
            }
        }
    }
}
