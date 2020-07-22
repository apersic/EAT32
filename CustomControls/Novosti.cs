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
    public partial class Novosti : UserControl
    {
        BazaPodataka baza = new BazaPodataka();
        BindingList<dbUgostiteljskiObjekt> popisObjekata;
        BindingList<dbUgostiteljskiObjekt> filtriranaLista;
        ObicniKorisnik aktivniKorisnik = null;

        public Novosti(ObicniKorisnik korisnik)
        {
            InitializeComponent();
            BindingList<dbUgostiteljskiObjekt> popisObjekata = baza.DohvatiSveUgostiteljskeObjekte();
            aktivniKorisnik = korisnik; 
            filtriranaLista = new BindingList<dbUgostiteljskiObjekt>(popisObjekata);
            uiOdabirFiltera.SelectedIndex = 2;
        }

        private void uiUnosPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            uiPopisObjekataContainer.Controls.Clear();

            if (filtriranaLista.Count != 0)
            {
                foreach (var item in filtriranaLista)
                {
                    if (item.naziv.Contains(uiUnosPretrazivanje.Text))
                    {
                        PrikaziObjekt(item);
                    }
                }
            }
        }

        public void PrikaziObjekt(dbUgostiteljskiObjekt item)
        {
            UgostiteljskiObjekt objekt = baza.DohvatiUgostiteljskiObjekt(item.id_ugostiteljskog_obrta);
            PrikazObjekta noviPrikaz = new PrikazObjekta(aktivniKorisnik);
            double ocjenaObjekta = baza.DohvatiProsjecnuOcjenuObjekta(item.id_ugostiteljskog_obrta);

            noviPrikaz.ccObjektID = objekt.IDRacuna;
            noviPrikaz.ccNazivObjekta = objekt.Naziv;
            noviPrikaz.ccAdresaObjekta = objekt.Adresa;
            noviPrikaz.ccProsjecnaOcjena = ocjenaObjekta.ToString();
            noviPrikaz.ccRadnoVrijemeObjekta = objekt.RadnoVrijemePocetak.ToString() + "-" + objekt.RadnoVrijemeKraj.ToString();

            uiPopisObjekataContainer.Controls.Add(noviPrikaz);
        }

        private void uiOdabirFiltera_SelectedValueChanged(object sender, EventArgs e)
        {
            uiPopisObjekataContainer.Controls.Clear();
            popisObjekata = baza.DohvatiSveUgostiteljskeObjekte();

            if (uiOdabirFiltera.SelectedIndex == 0)
            {
                filtriranaLista = new BindingList<dbUgostiteljskiObjekt>(popisObjekata.ToList());
            }

            if (uiOdabirFiltera.SelectedIndex == 1)
            {
                filtriranaLista = new BindingList<dbUgostiteljskiObjekt>(popisObjekata.Where(r => r.radno_vrijeme_pocetak < DateTime.Now.TimeOfDay && r.radno_vrijeme_kraj > DateTime.Now.TimeOfDay).ToList());
            }

            if (uiOdabirFiltera.SelectedIndex == 2)
            {
                filtriranaLista = new BindingList<dbUgostiteljskiObjekt>(popisObjekata.OrderByDescending(r => baza.DohvatiProsjecnuOcjenuObjekta(r.id_ugostiteljskog_obrta)).Take(5).ToList());
            }

            PrikaziSveObjekte();
        }

        public void PrikaziSveObjekte()
        {
            foreach (var item in filtriranaLista)
            {
                if (item.naziv.Contains(uiUnosPretrazivanje.Text))
                {
                    PrikaziObjekt(item);
                }
            }
        }
    }
}
