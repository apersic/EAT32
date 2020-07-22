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
    public partial class PrimljenaPoruka : UserControl
    {
        dbPoruka trenutnaPoruka = null;
        BazaPodataka baza = new BazaPodataka();  

        public PrimljenaPoruka(dbPoruka poruka)
        {
            InitializeComponent();
            trenutnaPoruka = poruka;
            Posiljatelj = baza.DohvatiKorisnickoIme(trenutnaPoruka.posiljatelj_id).ToString();
            Naslov = poruka.naslov;
            SadrzajPoruke = poruka.tekst;
        }

        public string Posiljatelj
        {
            set { uiOznakaPosiljatelj.Text = value; }
            get { return uiOznakaPosiljatelj.Text; }
        }

        public string Naslov
        {
            set { uiNaslovPoruke.Text = value; }
            get { return uiNaslovPoruke.Text; }
        }

        public string SadrzajPoruke
        {
            set { uiSadrzajPoruke.Text = value; }
            get { return uiSadrzajPoruke.Text; }
        }

        private void uiBtnOdgovori_Click(object sender, EventArgs e)
        {
            NovaPoruka formaNovaPoruka = new NovaPoruka(trenutnaPoruka.primatelj_id, trenutnaPoruka.posiljatelj_id, Naslov);
            formaNovaPoruka.ShowDialog();
            
        }

        private void uiBtnIzbrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baza.IzbrisiPoruku(trenutnaPoruka.id_poruke);                
            }
        }

        private void uiContainerNaslov_Click(object sender, EventArgs e)
        {
            ToggleViewMessage();
        }

        private void uiDropdown_Click(object sender, EventArgs e)
        {
            ToggleViewMessage();
        }


        public void ToggleViewMessage()
        {
            if (uiSadrzajPoruke.Visible == false)
            {
                this.Size = new Size(501, 116);
                uiSadrzajPoruke.Visible = true;
            }
            else
            {
                this.Size = new Size(501, 51);
                uiSadrzajPoruke.Visible = false;
            }
        }
    }
}
