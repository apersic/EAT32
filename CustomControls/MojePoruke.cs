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
    public partial class MojePoruke : UserControl
    {
        private int ID;
        BazaPodataka baza = new BazaPodataka();

        /// <summary>
        /// Prikaz poslanih i primljenih poruka
        /// </summary> 
        public MojePoruke(int idRacuna)
        {
            InitializeComponent();
            ID = idRacuna;
        }

        /// <summary>
        /// Kreiranje nove poruke
        /// </summary> 
        private void uiControlsNovaPoruka_Click(object sender, EventArgs e)
        {
            NovaPoruka novaPoruka = new NovaPoruka(ID);
            novaPoruka.ShowDialog();
            OsvjeziPoslanePoruke();
        }

        private void MojePoruke_Load(object sender, EventArgs e)
        {
            OsvjeziPrimljenePoruke();
        }

        /// <summary>
        /// Dohvaćanje primljenih poruka 
        /// </summary> 
        public void OsvjeziPrimljenePoruke()
        {
            uiContainerPoruke.Controls.Clear();

            var poruke = baza.DohvatiMojePrimljenePoruke(ID);

            if (poruke == null)
            {
                Label info = new Label();
                info.Text = "Nemate primljenih poruka.";
                uiContainerPoruke.Controls.Add(info);
            }
            else
            {
                foreach (var poruka in poruke)
                {
                    PrimljenaPoruka trenutnaPoruka = new PrimljenaPoruka(poruka);
                    uiContainerPoruke.Controls.Add(trenutnaPoruka);
                }
            }
        }

        /// <summary>
        /// Dohvaćanje poslanih poruka 
        /// </summary> 
        public void OsvjeziPoslanePoruke()
        {
            uiContainerPoruke.Controls.Clear();

            var poruke = baza.DohvatiMojePoslanePoruke(ID);

            if (poruke == null)
            {
                Label info = new Label();
                info.Text = "Nemate poslanih poruka.";
                uiContainerPoruke.Controls.Add(info);
            }
            else
            {
                foreach (var poruka in poruke)
                {
                    PoslanaPoruka trenutnaPoruka = new PoslanaPoruka(poruka);
                    uiContainerPoruke.Controls.Add(trenutnaPoruka);
                }
            }
        }

        /// <summary>
        /// Animacija button-a Primljene poruke 
        /// </summary> 
        public void OsvjeziSuceljePrimljenePoruke()
        {
            uiPrimljenePoruke.BackColor = Color.FromArgb(255, 87, 34);
            uiPoslanePoruke.BackColor = Color.FromArgb(64, 64, 64);

            uiPrimljenePoruke.ForeColor = Color.Black;
            uiPoslanePoruke.ForeColor = Control.DefaultBackColor;
        }

        /// <summary>
        /// Animacija button-a Poslane poruke 
        /// </summary> 
        public void OsvjeziSuceljePoslanePoruke()
        {
            uiPoslanePoruke.BackColor = Color.FromArgb(255, 87, 34);
            uiPrimljenePoruke.BackColor = Color.FromArgb(64, 64, 64);

            uiPoslanePoruke.ForeColor = Color.Black;
            uiPrimljenePoruke.ForeColor = Control.DefaultBackColor;
        }

        private void uiPrimljenePoruke_Click(object sender, EventArgs e)
        {
            OsvjeziPrimljenePoruke();
            OsvjeziSuceljePrimljenePoruke();
        }

        private void uiPoslanePoruke_Click(object sender, EventArgs e)
        {
            OsvjeziPoslanePoruke();
            OsvjeziSuceljePoslanePoruke();
        }
    }
}
