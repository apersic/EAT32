
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaRegistracija
{
    public partial class PrikazObjekta : UserControl
    {
        private int idObjekta;
        ObicniKorisnik aktivniKorisnik = null;

        public PrikazObjekta(ObicniKorisnik korisnik)
        {
            InitializeComponent();
            aktivniKorisnik = korisnik;
        }

        /// <summary>
        /// Dohvaća ili postavlja ID objekta koji se proslijeđuje konstruktoru forme za narudzbu, rezervaciju ili navigaciju.
        /// </summary> 
        public int ccObjektID
        {
            set { idObjekta = value; }
            get { return idObjekta; }
        }

        /// <summary>
        /// Dohvaća ili postavlja sliku objekta koja se prikazuje na ovoj kontroli.
        /// </summary> 
        public Image ccSlikaObjekta
        {
            set { ccPrikazObjektaSlika.Image = value; }
            get { return ccPrikazObjektaSlika.Image; }
        }

        /// <summary>
        /// Dohvaća ili postavlja naziv objekta koji se prikazuje na ovoj kontroli.
        /// </summary> 
        public string ccNazivObjekta
        {
            set { ccPrikazObjektaNaziv.Text = value; }
            get { return ccPrikazObjektaNaziv.Text; }
        }

        /// <summary>
        /// Dohvaća ili postavlja adresu objekta koja se prikazuje na ovoj kontroli.
        /// </summary> 
        public string ccAdresaObjekta
        {
            set { ccPrikazObjektaAdresa.Text = value; }
            get { return ccPrikazObjektaAdresa.Text; }
        }

        /// <summary>
        /// Dohvaća ili postavlja radno vrijeme objekta koje se prikazuje na ovoj kontroli.
        /// </summary> 
        public string ccRadnoVrijemeObjekta
        {
            set { ccPrikazObjektaRadnoVrijeme.Text = value; }
            get { return ccPrikazObjektaRadnoVrijeme.Text; }
        }

        /// <summary>
        /// Dohvaća ili postavlja prosječnu ocjenu objekta koja se prikazuje na ovoj kontroli.
        /// </summary> 
        public string ccProsjecnaOcjena
        {
            set { ccPrikazObjektaOcjena.Text = value; }
            get { return ccPrikazObjektaOcjena.Text; }
        }

        private void OtvoriProfil_Click(object sender, EventArgs e)
        {
            UgostiteljskiObjektProfil ugostiteljskiObjektProfil = new UgostiteljskiObjektProfil(idObjekta, aktivniKorisnik);
            ugostiteljskiObjektProfil.Show();
        }
    }
}
