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
    public partial class ONama : UserControl
    {
        /// <summary>
        /// Prima odabrani ugostiteljski objekt i prikazuje osnovne informacije o njemu, te recenzije 
        /// </summary> 

        BazaPodataka baza = new BazaPodataka();
        private UgostiteljskiObjekt trenutniUgoObjekt = null;
        private ObicniKorisnik trenutniKorisnik = null;
        private BindingList<dbRecenzija> sveRecenzije = null;

        public ONama(UgostiteljskiObjekt ugostiteljskiObjekt, ObicniKorisnik korisnik)
        {
            InitializeComponent();
            trenutniUgoObjekt = ugostiteljskiObjekt;
            trenutniKorisnik = korisnik;
            sveRecenzije = baza.DohvatiSveRecenzije(trenutniUgoObjekt.IDRacuna);
        }

        private void ONama_Load(object sender, EventArgs e)
        {
            uiImeUgostiteljskogObjekta.Text = trenutniUgoObjekt.Naziv;
            uiAdresa.Text = trenutniUgoObjekt.Adresa;
            uiBrojTelefona.Text = trenutniUgoObjekt.BrojTelefona;
            uiRadnoVrijemePoc.Text = trenutniUgoObjekt.RadnoVrijemePocetak.ToString();
            uiRadnoVrijemeKraj.Text = trenutniUgoObjekt.RadnoVrijemeKraj.ToString();
            uiEmail.Text = trenutniUgoObjekt.Email;

            foreach (var item in sveRecenzije)
            {
                string posiljatelj = baza.DohvatiImeRecenzenta(item.narudzba_id);
                PrikazRecenzije recenzija = new PrikazRecenzije(posiljatelj, int.Parse(item.ocjena.ToString()), item.komentar);
                uiPrikazRecenzijaObjekta.Controls.Add(recenzija);
            }
        }

        private void uiPretplatiKorisnika_Click(object sender, EventArgs e)
        {
            if (baza.PretplatiKorisnika(trenutniKorisnik.IDRacuna, trenutniUgoObjekt.IDRacuna) == false)
            {
                Notifikacija novaNotifikacija = new Notifikacija("Uspjesna pretplata", "Sada ste pretplaćeni na ovaj objekt!", "potvrda");
                novaNotifikacija.ShowDialog();
            }
            else
            {
                Notifikacija novaNotifikacija = new Notifikacija("Obavijest", "Već ste pretplaćeni na ovaj objekt!", "obavijest");
                novaNotifikacija.ShowDialog();
            }
        }
    }
}
