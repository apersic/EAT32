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
    public partial class MojeRecenzije : UserControl
    {
        UgostiteljskiObjekt aktivniObjekt = null;
        private BindingList<dbRecenzija> sveRecenzije = null;
        BazaPodataka baza = new BazaPodataka();

        public MojeRecenzije(UgostiteljskiObjekt objekt)
        {
            InitializeComponent();
            aktivniObjekt = objekt;
            sveRecenzije = baza.DohvatiSveRecenzije(aktivniObjekt.IDRacuna);
        }

        private void MojeRecenzije_Load(object sender, EventArgs e)
        {
            foreach (var item in sveRecenzije)
            {
                string posiljatelj = baza.DohvatiImeRecenzenta(item.narudzba_id);
                PrikazRecenzije recenzija = new PrikazRecenzije(posiljatelj, int.Parse(item.ocjena.ToString()), item.komentar);
                uiContainerRecenzije.Controls.Add(recenzija);
            }

            uiProsjecnaOcjena.Text = baza.DohvatiProsjecnuOcjenuObjekta(aktivniObjekt.IDRacuna).ToString();
        }
    }
}
