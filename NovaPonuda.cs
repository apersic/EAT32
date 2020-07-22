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
    public partial class NovaPonuda : Form
    {
        BazaPodataka baza = new BazaPodataka();
        int idObjekta;

        public NovaPonuda(int objekt)
        {
            InitializeComponent();
            idObjekta = objekt;
        }

        private void uiZatvoriProzor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSpremi_Click_1(object sender, EventArgs e)
        {
            if (uiUnosOpis.Text != "")
            {
                baza.UpisiPonudu(idObjekta, uiUnosOpis.Text);
                Notifikacija formNovaNotifikacija = new Notifikacija("Uspjesno uneseno", "Ponuda je uspjesno kreirana!", "potvrda");
                formNovaNotifikacija.ShowDialog();
                this.Close();
            }
        }
    }
}
