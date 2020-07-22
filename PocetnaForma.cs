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
    public partial class PocetnaForma : Form
    {
        BazaPodataka baza = new BazaPodataka();
        Registracija registracija;

        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void uiPrijava_Click(object sender, EventArgs e)
        {
            if (baza.Autentikacija(uiUnosKorisnickoIme.Text, uiUnosLozinka.Text) == 1)
            {
                int idAktivnogKorisnika = baza.DohvatiIDRacuna(uiUnosKorisnickoIme.Text);
                ObicniKorisnik aktivniKorisnik = baza.DohvatiObicnogKorisnika(idAktivnogKorisnika);
                KorisnikGlavna korisnikGlavna = new KorisnikGlavna(aktivniKorisnik);
                korisnikGlavna.ShowDialog();
                this.Close();
            }

            else if (baza.Autentikacija(uiUnosKorisnickoIme.Text, uiUnosLozinka.Text) == 2)
            {
                int idAktivnogUgostitelja = baza.DohvatiIDRacuna(uiUnosKorisnickoIme.Text);
                UgostiteljskiObjekt aktivniUgostitelj = baza.DohvatiUgostiteljskiObjekt(idAktivnogUgostitelja);
                UgostiteljGlavna ugostiteljGlavna = new UgostiteljGlavna(aktivniUgostitelj);
                ugostiteljGlavna.ShowDialog();
                this.Close();
            }

            else
            {
                Notifikacija formNovaNotifikacija = new Notifikacija("Neuspješna autentikacija", "Pogrešno uneseno korisničko ime ili lozinka", "upozorenje");
                formNovaNotifikacija.ShowDialog();
            }
        }

        private void uiRegistracija_Click(object sender, EventArgs e)
        {
            registracija = new Registracija();
            registracija.ShowDialog();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            uiUnosKorisnickoIme.Focus();
        }

        private void uiZatvoriProzor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiOpenHelper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, "..\\..\\Dokumentacija\\EAT32Helper.chm"));
        }
    }
}
