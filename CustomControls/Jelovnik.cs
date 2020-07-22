using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrijavaRegistracija.CustomControls;

namespace PrijavaRegistracija.CustomControls
{
    public partial class Jelovnik : UserControl
    {
        private BazaPodataka baza = new BazaPodataka();
        private UgostiteljskiObjekt trenutniObjekt = null;
        private ObicniKorisnik trenutniKorisnik = null;
        private double iznosNarudzbe = 0;
        private BindingList<Artikl> narudzbaPrikaz = new BindingList<Artikl>();
        private BindingList<StavkaNarudzbe> stavkaNarudzbe = new BindingList<StavkaNarudzbe>();
        private dbNarudžba novaNarudzba = null;

        public Jelovnik(UgostiteljskiObjekt ugostiteljskiObjekt, ObicniKorisnik korisnik)
        {
            InitializeComponent();
            trenutniObjekt = ugostiteljskiObjekt;
            trenutniKorisnik = korisnik;
        }

        public void OsvjeziMojuPonudu()
        {
            var bs = new BindingSource();
            bs.DataSource = baza.DohvatiPonudeObjekta(trenutniObjekt.IDRacuna);
            uiOdabirPonude.DataSource = bs;
            uiOdabirPonude.ValueMember = "id_ponude";
            uiOdabirPonude.DisplayMember = "opis";
        }

        public void PrikaziArtiklePonude(int idPonude)
        {
            uiJelovnikContainer.DataSource = null;

            BindingList<dbArtikl> listaArtikla = baza.DohvatiArtiklePonude(idPonude);
            BindingList<Artikl> jelovnikLista = new BindingList<Artikl>();

            foreach (var item in listaArtikla)
            {
                Artikl trenutniArtikl = new Artikl(item.id_artikla ,item.naziv, double.Parse(item.cijena));
                jelovnikLista.Add(trenutniArtikl);
            }

            uiJelovnikContainer.DataSource = jelovnikLista;          
        }

        private void uiOdabirPonude_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbPonuda ponuda = uiOdabirPonude.SelectedItem as dbPonuda;

            PrikaziArtiklePonude(ponuda.id_ponude);
        }

        private void Jelovnik_Load(object sender, EventArgs e)
        {
            OsvjeziMojuPonudu();
            PrikaziArtiklePonude((uiOdabirPonude.SelectedItem as dbPonuda).id_ponude);
        }

        private void uiDodajArtikl_Click(object sender, EventArgs e)
        {
            Artikl odabraniArtikl = uiJelovnikContainer.SelectedRows[0].DataBoundItem as Artikl;
            narudzbaPrikaz.Add(odabraniArtikl);

            ProvjeriStavkeNarudzbe(odabraniArtikl);

            uiNarudzbaContainer.DataSource = narudzbaPrikaz;
            iznosNarudzbe += odabraniArtikl.CijenaArtikla;
            uiIznosNarudzbe.Text = iznosNarudzbe.ToString();
        }

        private void uiIzbrisiArtikl_Click(object sender, EventArgs e)
        {
            Artikl odabraniArtikl = uiNarudzbaContainer.SelectedRows[0].DataBoundItem as Artikl;

            foreach (var item in narudzbaPrikaz)
            {
                if (item.IdArtikla == odabraniArtikl.IdArtikla)
                {
                    iznosNarudzbe -= item.CijenaArtikla;
                    uiIznosNarudzbe.Text = iznosNarudzbe.ToString();
                    narudzbaPrikaz.Remove(item);
                    MakniStavkuNarudzbe(item);
                    break;
                }
            }

            uiNarudzbaContainer.DataSource = null;
            uiNarudzbaContainer.DataSource = narudzbaPrikaz;
        }

        private void uiNaruci_Click(object sender, EventArgs e)
        {
            novaNarudzba = baza.KreirajNarudzbu(trenutniObjekt.IDRacuna, trenutniKorisnik.IDRacuna, DateTime.Now);

            foreach (var item in stavkaNarudzbe)
            {
                baza.KreirajStavkuNarudzbe(item.IdArtikla, novaNarudzba.id_narudzbe, item.Kolicina);
            }

            Notifikacija novaNotifikacija = new Notifikacija("Narudzba kreirana", "Narudzba je uspjesno poslana!", "potvrda");
            novaNotifikacija.ShowDialog();

            OsvjeziPrikaz();
        }

        /// <summary>
        /// Provjerava da li se trazeni artikl već nalazi u stavkama narudzbe, ako se vec nalazi onda kolicinu toga artikla u stavki inkrementira za 1, a ukoliko ne postoji onda kreira novu stavku sa inicijalnom kolicinom 1.
        /// </summary> 
        public void ProvjeriStavkeNarudzbe(Artikl odabraniArtikl)
        {
            bool postojiArtikl = false;

            foreach (var stavka in stavkaNarudzbe)
            {
                if (stavka.IdArtikla == odabraniArtikl.IdArtikla)
                {
                    stavka.Kolicina += 1;
                    postojiArtikl = true;
                }
            }

            if (postojiArtikl == false)
            {
                StavkaNarudzbe novaStavka = new StavkaNarudzbe(odabraniArtikl.IdArtikla);
                stavkaNarudzbe.Add(novaStavka);
            }
        }

        /// <summary>
        /// Prilikom brisanja artikla sa narudzbe provjerava da li je kolicina tog artikla veća ili jednaka 2, ako je onda ju dekrementira za 1, a ukoliko nije onda uklanja artikl sa stavki narudzbe.
        /// </summary> 
        public void MakniStavkuNarudzbe(Artikl odabraniArtikl)
        {
            bool artiklPronaden = false;
            StavkaNarudzbe nadeniArtikl = null;

            foreach (var item in stavkaNarudzbe)
            {
                if (item.IdArtikla == odabraniArtikl.IdArtikla)
                {
                    if (item.Kolicina >= 2)
                    {
                        item.Kolicina -= 1;
                        artiklPronaden = true;
                        nadeniArtikl = item;
                    }
                }
            }

            if (artiklPronaden == false)
            {
                stavkaNarudzbe.Remove(nadeniArtikl);
            }
        }

        /// <summary>
        /// Osvjezava prikaz stavki narudzbe nakon kreiranja narudzbe, odnosno kreira nove prazne liste, a DataSource postavlja na prethodnu listu.
        /// </summary> 
        public void OsvjeziPrikaz()
        {
            stavkaNarudzbe = new BindingList<StavkaNarudzbe>();
            narudzbaPrikaz = new BindingList<Artikl>();
            uiNarudzbaContainer.DataSource = narudzbaPrikaz;
        }
    }
}
