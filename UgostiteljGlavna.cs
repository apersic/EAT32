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
using PrijavaRegistracija.CustomControls;

namespace PrijavaRegistracija
{
    public partial class UgostiteljGlavna : Form
    {
        BazaPodataka baza = new BazaPodataka();
        UgostiteljskiObjekt aktivniUgostitelj = null;

        public UgostiteljGlavna(UgostiteljskiObjekt trenutni)
        {
            InitializeComponent();
            aktivniUgostitelj = trenutni;
        }


        public void PrikaziMojProfil()
        {
            uiAktivniPanel.Top = uiSideBarMojProfil.Top;

            uiContainerSection.Controls.Clear();
            uiContainerSection.Controls.Add(new MojProfil(aktivniUgostitelj));
        }

        public void PrikaziPopisNarudzbi()
        {
            uiAktivniPanel.Top = uiSideBarNarudzbe.Top;

            uiContainerSection.Controls.Clear();
            uiContainerSection.Controls.Add(new PopisNarudzbi(aktivniUgostitelj));
        }

        public void PrikaziMojuPonudu()
        {
            uiAktivniPanel.Top = uiSideBarMojaPonuda.Top;

            uiContainerSection.Controls.Clear();
            uiContainerSection.Controls.Add(new MojaPonuda(aktivniUgostitelj));
        }

        public void PrikaziMojePoruke()
        {
            uiAktivniPanel.Top = uiSideBarMojePoruke.Top;

            uiContainerSection.Controls.Clear();
            uiContainerSection.Controls.Add(new MojePoruke(aktivniUgostitelj.IDRacuna));
        }

        public void PrikaziMojeRecenzije()
        {
            uiAktivniPanel.Top = uiSideBarMojeRecenzije.Top;

            uiContainerSection.Controls.Clear();
            uiContainerSection.Controls.Add(new MojeRecenzije(aktivniUgostitelj));
        }

        private void UgostiteljGlavna_Load(object sender, EventArgs e)
        {
            PrikaziMojProfil();
        }

        private void uiZatvoriProzor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSideBarMojProfil_Click(object sender, EventArgs e)
        {
            PrikaziMojProfil();
        }

        private void uiSideBarNarudzbe_Click(object sender, EventArgs e)
        {
            PrikaziPopisNarudzbi();
        }

        private void uiSideBarMojaPonuda_Click(object sender, EventArgs e)
        {
            PrikaziMojuPonudu();
        }

        private void uiSideBarMojePoruke_Click(object sender, EventArgs e)
        {
            PrikaziMojePoruke();
        }

        private void uiSideBarMojeRecenzije_Click(object sender, EventArgs e)
        {
            PrikaziMojeRecenzije();
        }

        private void uiOpenHelper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, "..\\..\\Dokumentacija\\EAT32Helper.chm"));
        }
    }
}
