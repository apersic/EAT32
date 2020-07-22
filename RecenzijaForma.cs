using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaRegistracija
{
    public partial class RecenzijaForma : Form
    {
        int ocjenaNarudzbe;
        string komentarNarudzbe;
        int narudzbaId;
        BazaPodataka baza = new BazaPodataka();

        public RecenzijaForma(int idNarudzbe)
        {
            InitializeComponent();
            narudzbaId = idNarudzbe;
        }

        private void uiZatvoriProzor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiOcjeni_Click(object sender, EventArgs e)
        {
            ocjenaNarudzbe = int.Parse(uiOcjenaNarudzbe.SelectedItem.ToString());
            komentarNarudzbe = uiKomentar.Text;

            dbRecenzija novaRecenzija = baza.KreirajRecenziju(narudzbaId, ocjenaNarudzbe, komentarNarudzbe);

            Notifikacija potvrda = new Notifikacija("Ocijena poslana!", "Ocijena je uspješno poslana", "potvrda");
            potvrda.Show();

            uiKomentar.Text = "";         
        }

        private void RecenzijaForma_Load(object sender, EventArgs e)
        {
            uiOcjenaNarudzbe.SelectedIndex = 0;
        }
    }
}
