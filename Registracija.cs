using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaRegistracija
{
    public partial class Registracija : Form
    {
        BazaPodataka baza = new BazaPodataka();
        bool odabirObicniKorisnik = true;
        bool odabirUgostiteljskiObjekt;
        bool unosIspravan = true;

        public Registracija()
        {
            InitializeComponent();
        }

        private void uiRegistracija_Click(object sender, EventArgs e)
        {
            if (odabirObicniKorisnik == true)
            {
                if (ProvjeriPolja("obicni") == true && unosIspravan == true)
                {
                    string imePrezime = uiUnosNaziv.Text;
                    string[] poljeImePrezime = imePrezime.Split(null);

                    ObicniKorisnik noviKorisnik = new ObicniKorisnik(uiUnosKorisnickoIme.Text, uiUnosLozinka.Text, uiUnosEmail.Text, uiUnosAdresa.Text, uiUnosBrojTelefona.Text, poljeImePrezime[0], poljeImePrezime[1]);

                    baza.UpisiObicnogKorisnika(noviKorisnik);
                }
                else
                {
                    Notifikacija novaNotifikacija = new Notifikacija("Greška", "Morate ispuniti sva polja!", "upozorenje");
                    novaNotifikacija.ShowDialog();
                    return;
                }
            }

            if (odabirUgostiteljskiObjekt == true)
            {
                if (ProvjeriPolja("ugostitelj") == true)
                {
                    UgostiteljskiObjekt noviObjekt = new UgostiteljskiObjekt(uiUnosKorisnickoIme.Text, uiUnosLozinka.Text, uiUnosEmail.Text, uiUnosAdresa.Text, uiUnosBrojTelefona.Text, uiUnosNaziv.Text, TimeSpan.Parse(uiUnosRadnoVrijemePocetak.Text), TimeSpan.Parse(uiUnosRadnoVrijemeKraj.Text));

                    baza.UpisiUgostiteljskiObjekt(noviObjekt);
                }
                else
                {
                    Notifikacija novaNotifikacija = new Notifikacija("Greška", "Morate ispuniti sva polja!", "upozorenje");
                    novaNotifikacija.ShowDialog();
                    return;
                }
            }

            Notifikacija formNovaNotifikacija = new Notifikacija("Uspješna registracija", "Registracija je uspješna!", "potvrda");
            formNovaNotifikacija.ShowDialog();
            this.Close();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            uiOznakaNaslov.Text = "Registracija - Obicni korisnik";
        }

        private void uiZatvoriProzor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiOdabirObicniKorisnik_Click(object sender, EventArgs e)
        {
            OdaberiObicnogKorisnika();
        }

        private void uiOdabirUgostiteljskiObjekt_Click(object sender, EventArgs e)
        {
            OdaberiUgostiteljskiObjekt();
        }

        private void uiUnosKorisnickoIme_KeyUp(object sender, KeyEventArgs e)
        {
            if (baza.DostupnoKorisnickoIme(uiUnosKorisnickoIme.Text) == false)
            {
                uiUpozorenjeZauzetoKorisnickoIme.Text = "Zauzeto";
                unosIspravan = false;
            }
            else
            {
                uiUpozorenjeZauzetoKorisnickoIme.Text = "";
                unosIspravan = true;
            }
        }

        private void uiUnosPonovljenaLozinka_Leave(object sender, EventArgs e)
        {
            if (uiUnosPonovljenaLozinka.Text != uiUnosLozinka.Text)
            {
                uiUpozorenjePonovljenaLozinka.Text = "Lozinke nisu jednake!";
                unosIspravan = false;
            }
            else
            {
                uiUpozorenjePonovljenaLozinka.Text = "";
                unosIspravan = true; ;
            }
        }

        private void uiUnosLozinka_Leave(object sender, EventArgs e)
        {
            if (uiUnosLozinka.Text != uiUnosPonovljenaLozinka.Text)
            {
                uiUpozorenjePonovljenaLozinka.Text = "Lozinke nisu jednake!";
                unosIspravan = false;
            }
            else
            {
                uiUpozorenjePonovljenaLozinka.Text = "";
                unosIspravan = true; ;
            }
        }

        private void uiUnosLozinka_KeyUp(object sender, KeyEventArgs e)
        {
            if (uiUnosLozinka.Text.Length < 6)
            {
                uiUpozorenjeLozinka.Text = "Prekratka lozinka!";
                unosIspravan = false;
            }
            else
            {
                uiUpozorenjeLozinka.Text = "";
                unosIspravan = true;
            }
        }

        public void OdaberiObicnogKorisnika()
        {
            uiOznakaNaslov.Text = "Registracija - Obicni korisnik";
            uiOdabirObicniKorisnik.BackColor = Control.DefaultBackColor;
            uiOdabirUgostiteljskiObjekt.BackColor = Color.FromArgb(64, 64, 64);

            odabirObicniKorisnik = true;
            odabirUgostiteljskiObjekt = false;

            uiOznakaNaziv.Text = "Ime i prezime: ";
            uiOznakaRadnoVrijeme.Visible = false;
            uiOznakaCrtica.Visible = false;
            uiContainerRadnoVrijemePocetak.Visible = false;
            uiUnosRadnoVrijemePocetak.Visible = false;
            uiContainerRadnoVrijemeKraj.Visible = false;
            uiUnosRadnoVrijemeKraj.Visible = false;
        }

        public void OdaberiUgostiteljskiObjekt()
        {
            uiOznakaNaslov.Text = "Registracija - Ugostiteljski objekt";
            uiOdabirObicniKorisnik.BackColor = Color.FromArgb(64, 64, 64);
            uiOdabirUgostiteljskiObjekt.BackColor = Control.DefaultBackColor;

            odabirObicniKorisnik = false;
            odabirUgostiteljskiObjekt = true;

            uiOznakaNaziv.Text = "Naziv objekta: ";
            uiOznakaRadnoVrijeme.Visible = true;
            uiOznakaCrtica.Visible = true;
            uiContainerRadnoVrijemePocetak.Visible = true;
            uiUnosRadnoVrijemePocetak.Visible = true;
            uiContainerRadnoVrijemeKraj.Visible = true;
            uiUnosRadnoVrijemeKraj.Visible = true;
        }

        public bool ProvjeriPolja(string tip)
        {
            if (tip == "obicni")
            {
                if (uiUnosKorisnickoIme.Text != "" && uiUnosLozinka.Text != "" && uiUnosPonovljenaLozinka.Text != "" && uiUnosEmail.Text != "" && uiUnosAdresa.Text != "" && uiUnosBrojTelefona.Text != "" && uiUnosNaziv.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (uiUnosKorisnickoIme.Text != "" && uiUnosLozinka.Text != "" && uiUnosPonovljenaLozinka.Text != "" && uiUnosEmail.Text != "" && uiUnosAdresa.Text != "" && uiUnosBrojTelefona.Text != "" && uiUnosNaziv.Text != "" && uiUnosRadnoVrijemePocetak.Text != "" && uiUnosRadnoVrijemeKraj.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void uiOpenHelper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, "..\\..\\Dokumentacija\\EAT32Helper.chm"));
        }
    }
}
