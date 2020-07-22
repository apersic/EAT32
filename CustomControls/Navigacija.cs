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
    public partial class Navigacija : UserControl
    {
        /// <summary>
        /// Kontrola prima adresu (string) ugostiteljskog objekta čiji profil je odabran i prikazuje njenu lokaciju
        /// koristeći Google Maps
        /// </summary> 

        private string homeUrl = "https://www.google.com/maps/dir/";

        public Navigacija(string adresa)
        {
            InitializeComponent();
            homeUrl += adresa.Replace(" ", "+") + "/";
            uiNavigacijaPrikaz.Navigate(homeUrl);
        }

        private void uiNavigacija_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
