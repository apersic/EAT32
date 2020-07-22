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
    public partial class MojProfilKorisnik : UserControl
    {
        ObicniKorisnik prijavljeniKorisnik = null;
        BazaPodataka baza = new BazaPodataka();

        public MojProfilKorisnik(ObicniKorisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void MojProfilKorisnik_Load(object sender, EventArgs e)
        {
            uiUnosNaziv.Text = prijavljeniKorisnik.KorisnickoIme;
            uiUnosEmail.Text = prijavljeniKorisnik.Email;
            uiUnosAdresa.Text = prijavljeniKorisnik.Adresa;
            uiUnosEmail.Text = prijavljeniKorisnik.Email;
            uiUnosLozinka.Text = prijavljeniKorisnik.Lozinka;
        }

        private void uiOtkljucajPodatke_Click(object sender, EventArgs e)
        {
            OtkljucajPodatke();
        }

        private void OtkljucajPodatke()
        {
            if (uiUnosNaziv.Enabled == false)
            {
                uiUnosNaziv.Enabled = true;
                uiUnosEmail.Enabled = true;
                uiUnosLozinka.Enabled = true;
                uiUnosAdresa.Enabled = true;
                uiUnosBrojTelefona.Enabled = true;
                uiSpremiPromjene.Visible = true;
                uiOtkljucajPodatke.ImageLocation = "..\\..\\Resources\\icons8-padlock-24.png";
            }
            else
            {
                uiUnosNaziv.Enabled = false;
                uiUnosEmail.Enabled = false;
                uiUnosLozinka.Enabled = false;
                uiUnosAdresa.Enabled = false;
                uiUnosBrojTelefona.Enabled = false;
                uiSpremiPromjene.Visible = false;
                uiOtkljucajPodatke.ImageLocation = "..\\..\\Resources\\icons8-lock-24.png";
            }
        }

        public bool ProvjeriIspunjenostPolja()
        {
            if (uiUnosNaziv.Text != "" && uiUnosEmail.Text != "" && uiUnosLozinka.Text != "" && uiUnosAdresa.Text != "" && uiUnosBrojTelefona.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void uiSpremiPromjene_Click(object sender, EventArgs e)
        {
            if (ProvjeriIspunjenostPolja())
            {
               baza.AzurirajObicnogKorisnika(prijavljeniKorisnik.IDRacuna, uiUnosAdresa.Text ,uiUnosNaziv.Text, uiUnosEmail.Text, uiUnosLozinka.Text, uiUnosBrojTelefona.Text);

                Notifikacija novaNotifikacija = new Notifikacija("Uspjesno azuriranje", "Podaci su uspjesno azurirani!", "potvrda");
                novaNotifikacija.ShowDialog();
            }
        }
    }
}
