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
    public partial class Notifikacija : Form
    {
        public Notifikacija(string naslov, string informacija, string tip)
        {
            InitializeComponent();
            Naslov = naslov;
            Informacija = informacija;

            if (tip == "potvrda")
            {
                uiSlikaNotifikacije.ImageLocation = "..\\..\\Resources\\icons8-checked-60.png";
            }
            else if (tip == "upozorenje")
            {
                uiSlikaNotifikacije.ImageLocation = "..\\..\\Resources\\icons8-high-priority-60.png";
            }
            else
            {
                uiSlikaNotifikacije.ImageLocation = "..\\..\\Resources\\icons8-about-60.png";
            }
        }

        public string Naslov
        {
            set { uiOznakaNaslov.Text = value; }
            get { return uiOznakaNaslov.Text; }
        }

        public string Informacija
        {
            set { uiOznakaInformacija.Text = value; }
            get { return uiOznakaInformacija.Text; }
        }

        private void uiZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiBtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
