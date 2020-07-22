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
    public partial class MojaPonuda : UserControl
    {
        UgostiteljskiObjekt aktivniObjekt = null;
        BazaPodataka baza = new BazaPodataka();

        public MojaPonuda(UgostiteljskiObjekt objekt)
        {
            InitializeComponent();
            aktivniObjekt = objekt;
        }

        private void MojaPonuda_Load(object sender, EventArgs e)
        {
            OsvjeziMojuPonudu();
        }

        public void OsvjeziMojuPonudu()
        {
            var bs = new BindingSource();
            bs.DataSource = baza.DohvatiPonudeObjekta(aktivniObjekt.IDRacuna);
            uiOdabirPonude.DataSource = bs;
            uiOdabirPonude.ValueMember = "id_ponude";
            uiOdabirPonude.DisplayMember = "opis";
        }

        public void PrikaziArtiklePonude(int idPonude)
        {
            uiContainerArtikliPonude.Controls.Clear();

            BindingList<dbArtikl> listaArtikla = baza.DohvatiArtiklePonude(idPonude);

            if (listaArtikla.Count != 0)
            {
                foreach (var artikl in listaArtikla)
                {
                    uiContainerArtikliPonude.Controls.Add(new PrikazArtikla(artikl));
                }
            }
        }

        private void uiOdabirPonude_SelectedValueChanged(object sender, EventArgs e)
        {
            dbPonuda ponuda = uiOdabirPonude.SelectedItem as dbPonuda;

            if (ponuda != null)
            {
                PrikaziArtiklePonude(ponuda.id_ponude);
            }
        }

        private void uiDodajArtikl_Click(object sender, EventArgs e)
        {
            dbPonuda ponuda = uiOdabirPonude.SelectedItem as dbPonuda;

            NoviArtikl formaArtikl = new NoviArtikl(ponuda);
            formaArtikl.ShowDialog();

            PrikaziArtiklePonude(ponuda.id_ponude);
        }

        private void uiKreirajPonudu_Click(object sender, EventArgs e)
        {
            NovaPonuda formaPonuda = new NovaPonuda(aktivniObjekt.IDRacuna);
            formaPonuda.ShowDialog();

            OsvjeziMojuPonudu();
        }
    }
}
