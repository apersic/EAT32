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
    public partial class KorisnikGlavna : Form
    {
        BazaPodataka baza = new BazaPodataka();
        ObicniKorisnik aktivniKorisnik = null;

        public KorisnikGlavna(ObicniKorisnik trenutni)
        {
            InitializeComponent();
            aktivniKorisnik = trenutni;
        }

        private void uiZatvoriProzor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PrikaziPocetnu()
        {
            uiContainerSection.Controls.Clear();
            uiContainerSection.Controls.Add(new Novosti(aktivniKorisnik));
        }

        public void PrikaziPoruke()
        {
            uiContainerSection.Controls.Clear();
            uiContainerSection.Controls.Add(new MojePoruke(aktivniKorisnik.IDRacuna));
        }

        private void KorisnikGlavna_Load(object sender, EventArgs e)
        {
            PrikaziPocetnu();
        }

        private void uiNovosti_Click(object sender, EventArgs e)
        {
            uiPomicniPanel.Top = uiNovosti.Top;
            PrikaziPocetnu();
        }

        private void uiPoruke_Click(object sender, EventArgs e)
        {
            uiPomicniPanel.Top = uiPoruke.Top;
            PrikaziPoruke();
        }

        private void uiMojProfil_Click(object sender, EventArgs e)
        {
            uiContainerSection.Controls.Clear();
            uiPomicniPanel.Top = uiMojProfil.Top;
            uiContainerSection.Controls.Add(new MojProfilKorisnik(aktivniKorisnik));
        }

        private void uiMojeNarudzbe_Click(object sender, EventArgs e)
        {
            uiContainerSection.Controls.Clear();
            uiPomicniPanel.Top = uiMojeNarudzbe.Top;
            uiContainerSection.Controls.Add(new NarudzbaPrikaz(aktivniKorisnik.IDRacuna));
        }

        private void uiOpenHelper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, "..\\..\\Dokumentacija\\EAT32Helper.chm"));
        }
    }
}
