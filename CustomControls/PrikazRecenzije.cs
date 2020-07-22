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
    public partial class PrikazRecenzije : UserControl
    {
        private string posiljatelj;
        private int ocjena;
        private string recenzija;

        /// <summary>
        /// Prihvaća podatke o recenziji i kreira prikaz recenzije
        /// </summary>
        public PrikazRecenzije(string korisnickoIme ,int recOcjena, string recTekst)
        {
            InitializeComponent();
            ocjena = recOcjena;
            recenzija = recTekst;
            posiljatelj = korisnickoIme;
        }

        private void PrikazRecenzije_Load(object sender, EventArgs e)
        {
            uiKorisnickoImeOP.Text = posiljatelj;
            uiRecenzijaOcjena.Text = ocjena.ToString();
            uiRecenzijaTekst.Text = recenzija;
        }
    }
}
