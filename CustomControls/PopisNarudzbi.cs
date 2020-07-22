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
    public partial class PopisNarudzbi : UserControl
    {
        BazaPodataka baza = new BazaPodataka();
        UgostiteljskiObjekt ugostiteljNarudzbe;

        public PopisNarudzbi(UgostiteljskiObjekt aktivniUgostitelj)
        {
            InitializeComponent();
            ugostiteljNarudzbe = aktivniUgostitelj;
        }

        private void PopisNarudzbi_Load(object sender, EventArgs e)
        {
            OsvjeziPopisNarudzbi();
        }

        public void OsvjeziPopisNarudzbi()
        {
            uiContainerNarudzbe.Controls.Clear();

            BindingList<dbNarudžba> popisNarudzbi = baza.DohvatiNarudzbeObjekta(ugostiteljNarudzbe.IDRacuna);

            foreach (var item in popisNarudzbi)
            {
                uiContainerNarudzbe.Controls.Add(new PrikazNarudzbe(item));
            }
        }
    }
}
