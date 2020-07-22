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
    public partial class MojProfil : UserControl
    {
        UgostiteljskiObjekt ugostiteljProfil;
        BazaPodataka baza = new BazaPodataka();

        public MojProfil(UgostiteljskiObjekt aktivniUgostitelj)
        {
            InitializeComponent();
            ugostiteljProfil = aktivniUgostitelj;

            NazivObjekta = ugostiteljProfil.Naziv;
            Email = ugostiteljProfil.Email;
            Lozinka = ugostiteljProfil.Lozinka;
            Adresa = ugostiteljProfil.Adresa;
            BrojTelefona = ugostiteljProfil.BrojTelefona;
            RadnoVrijemePocetak = ugostiteljProfil.RadnoVrijemePocetak.ToString();
            RadnoVrijemeKraj = ugostiteljProfil.RadnoVrijemeKraj.ToString();
        }

        public string NazivObjekta
        {
            set { uiUnosNaziv.Text = value; }
            get { return uiUnosNaziv.Text; }
        }

        public string Email
        {
            set { uiUnosEmail.Text = value; }
            get { return uiUnosEmail.Text; }
        }

        public string Lozinka
        {
            set { uiUnosLozinka.Text = value; }
            get { return uiUnosLozinka.Text; }
        }

        public string Adresa
        {
            set { uiUnosAdresa.Text = value; }
            get { return uiUnosAdresa.Text; }
        }

        public string BrojTelefona
        {
            set { uiUnosBrojTelefona.Text = value; }
            get { return uiUnosBrojTelefona.Text; }
        }

        public string RadnoVrijemePocetak
        {
            set { uiUnosRadnoVrijemePocetak.Text = value; }
            get { return uiUnosRadnoVrijemeKraj.Text; }
        }

        public string RadnoVrijemeKraj
        {
            set { uiUnosRadnoVrijemeKraj.Text = value; }
            get { return uiUnosRadnoVrijemeKraj.Text; }
        }

        private void uiOtkljucajPodatke_Click(object sender, EventArgs e)
        {
            ToggleOtkljucajPodatke();
        }

        public void ToggleOtkljucajPodatke()
        {
            if (uiUnosNaziv.Enabled == false)
            {
                uiUnosNaziv.Enabled = true;
                uiUnosEmail.Enabled = true;
                uiUnosLozinka.Enabled = true;
                uiUnosAdresa.Enabled = true;
                uiUnosBrojTelefona.Enabled = true;
                uiUnosRadnoVrijemePocetak.Enabled = true;
                uiUnosRadnoVrijemeKraj.Enabled = true;
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
                uiUnosRadnoVrijemePocetak.Enabled = false;
                uiUnosRadnoVrijemeKraj.Enabled = false;
                uiSpremiPromjene.Visible = false;
                uiOtkljucajPodatke.ImageLocation = "..\\..\\Resources\\icons8-lock-24.png";
            }
        }

        private void uiSpremiPromjene_Click(object sender, EventArgs e)
        {
            if (ProvjeriIspunjenostPolja() == true)
            {
                baza.AzurirajUgostiteljskiObjekt(ugostiteljProfil.IDRacuna, uiUnosNaziv.Text, uiUnosEmail.Text, uiUnosLozinka.Text, uiUnosAdresa.Text ,uiUnosBrojTelefona.Text, TimeSpan.Parse(uiUnosRadnoVrijemePocetak.Text), TimeSpan.Parse(uiUnosRadnoVrijemeKraj.Text));

                string porukaPretplatniku = $"Ugostiteljski objekt {ugostiteljProfil.Naziv} je azurirao informacije o sebi: " + Environment.NewLine + $"Naziv objekta: {uiUnosNaziv.Text}" + Environment.NewLine + $"Email adresa: {uiUnosEmail.Text}" + Environment.NewLine + $"Adresa: {uiUnosAdresa.Text}" + Environment.NewLine + $"Broj telefona: {uiUnosBrojTelefona.Text}" + Environment.NewLine + $"Radno vrijeme pocetak: {uiUnosRadnoVrijemePocetak.Text}" + Environment.NewLine + $"Radno vrijeme kraj: {uiUnosRadnoVrijemeKraj.Text}";

                baza.ObavijestiPretplatnike(ugostiteljProfil.IDRacuna, porukaPretplatniku);

                Notifikacija novaNotifikacija = new Notifikacija("Uspjesno azuriranje", "Podaci su uspjesno azurirani!", "potvrda");
                novaNotifikacija.ShowDialog();
            }
        }

        public bool ProvjeriIspunjenostPolja()
        {
            if (uiUnosNaziv.Text != "" && uiUnosEmail.Text != "" && uiUnosLozinka.Text != "" && uiUnosAdresa.Text != "" && uiUnosBrojTelefona.Text != "" && uiUnosRadnoVrijemePocetak.Text != "" && uiUnosRadnoVrijemeKraj.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
