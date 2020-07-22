using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrijavaRegistracija.CustomControls;

namespace PrijavaRegistracija
{
    public partial class UgostiteljskiObjektProfil : Form
    {
        /// <summary>
        /// Prikaz profila odabranog ugostiteljskog objekta 
        /// </summary> 

        BazaPodataka baza = new BazaPodataka();
        UgostiteljskiObjekt ugostiteljskiObjekt = null;
        ObicniKorisnik trenutniKorisnik = null;

        public UgostiteljskiObjektProfil(int idUgostiteljskogObjekta, ObicniKorisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
            ugostiteljskiObjekt = baza.DohvatiUgostiteljskiObjekt(idUgostiteljskogObjekta);
        }

        /// <summary>
        /// Profil se otvara s prikazom osnovnih podataka o ugostiteljskom objektu i recenzijama 
        /// </summary> 
        private void UgostiteljskiObjektProfil_Load(object sender, EventArgs e)
        {
            ONama oNama = new ONama(ugostiteljskiObjekt, trenutniKorisnik);
            uiControlLayout.Controls.Add(oNama);
        }

        /// <summary>
        /// Pomicanje highlight panela, čišćenje kontrola i prikaz navigacije 
        /// </summary> 
        private void uiNavigacija_Click(object sender, EventArgs e)
        {
            uiPomicanPanel.Top = uiNavigacija.Top;
            uiControlLayout.Controls.Clear();
            Navigacija navigacija = new Navigacija(ugostiteljskiObjekt.Adresa);
            uiControlLayout.Controls.Add(navigacija);
        }

        /// <summary>
        /// Zatvaranje profila ugostiteljskog objekta 
        /// </summary> 
        private void uiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Pomicanje highlight panela, čišćenje kontrola i osnovnih podataka 
        /// </summary> 
        private void uiONama_Click(object sender, EventArgs e)
        {
            uiPomicanPanel.Top = uiONama.Top;
            uiControlLayout.Controls.Clear();
            ONama oNama = new ONama(ugostiteljskiObjekt, trenutniKorisnik);
            uiControlLayout.Controls.Add(oNama);
        }

        /// <summary>
        /// Pomicanje highlight panela, čišćenje kontrola i prikaz izrade narudžbe 
        /// </summary> 
        private void uiNarudzba_Click(object sender, EventArgs e)
        {
            uiPomicanPanel.Top = uiNarudzba.Top;
            uiControlLayout.Controls.Clear();
            uiControlLayout.Controls.Add(new Jelovnik(ugostiteljskiObjekt, trenutniKorisnik));
        }

        private void uiOpenHelper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, "..\\..\\Dokumentacija\\EAT32Helper.chm"));
        }
    }
}
