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
    public partial class Narudzba : UserControl
    {
        string objektNaziv;
        string datumNarudzbe;
        int idNarudzbe;

        public Narudzba(string nazivObjekta, string datum, int narudzbaId)
        {
            InitializeComponent();
            objektNaziv = nazivObjekta;
            datumNarudzbe = datum;
            idNarudzbe = narudzbaId;
        }

        private void Narudzba_Load(object sender, EventArgs e)
        {
            uiImeUgostiteljkogObjekta.Text = objektNaziv;
            uiDatumNarudzbe.Text = datumNarudzbe;
        }

        private void uiOcijeni_Click(object sender, EventArgs e)
        {
            RecenzijaForma novaRecenzija = new RecenzijaForma(idNarudzbe);
            novaRecenzija.Show();
        }
    }
}
