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
    public partial class NovaPoruka : Form
    {
        BazaPodataka baza = new BazaPodataka();
        private int trenutniKorisnik;

        public NovaPoruka(int idPosiljatelj, int idPrimatelj = 0, string naslov = "")
        {
            InitializeComponent();

            trenutniKorisnik = idPosiljatelj;

            if (idPrimatelj != 0)
            {
                string korime = baza.DohvatiKorisnickoIme(idPrimatelj);
                Primatelj = korime;
            }

            if (naslov != "")
            {
                Naslov = "Re: " + naslov; 
            }
        }

        public string Primatelj
        {
            set { uiUnosPrimatelj.Text = value; }
            get { return uiUnosPrimatelj.Text; }
        }

        public string Naslov
        {
            set { uiUnosNaslov.Text = value; }
            get { return uiUnosNaslov.Text; }
        }

        public string Sadrzaj
        {
            set { uiUnosTekst.Text = value; }
            get { return uiUnosTekst.Text; }
        }

        private void uiUnosPrimatelj_TextChanged(object sender, EventArgs e)
        {
            ProvjeriUnosPrimatelja();
        }

        private void uiUnosNaslov_Leave(object sender, EventArgs e)
        {
            ProvjeriUnosNaslova();
        }

        public void ProvjeriUnosPrimatelja()
        {
            if (uiUnosPrimatelj.Text != "")
            {
                if (baza.DohvatiIDRacuna(uiUnosPrimatelj.Text) == -1)
                {
                    uiUpozorenjePrimatelj.Text = "Korisnik ne postoji!";
                }
                else
                {
                    uiUpozorenjePrimatelj.Text = "";
                }
            }
        }

        public void ProvjeriUnosNaslova()
        {
            if (uiUnosNaslov.Text == "")
            {
                uiUpozorenjeNaslov.Text = "Morate ispuniti naslov!";
            }
            else
            {
                uiUpozorenjeNaslov.Text = "";
            }
        }

        private void uiPosaljiPoruku_Click(object sender, EventArgs e)
        {
            if (baza.DohvatiIDRacuna(uiUnosPrimatelj.Text) != -1 && uiUnosNaslov.Text != "")
            {
                int idPrimatelja = baza.DohvatiIDRacuna(Primatelj);
                baza.PosaljiPoruku(trenutniKorisnik, idPrimatelja, Naslov, Sadrzaj);
                Notifikacija novaNotifikacija = new Notifikacija("Uspjesno poslano", "Poruka je uspjesno poslana!", "potvrda");
                novaNotifikacija.ShowDialog();
                this.Close();
            }
        }

        private void uiZatvoriProzor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
