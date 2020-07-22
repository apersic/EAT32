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
    public partial class NarudzbaPrikaz : UserControl
    {
        int korisnikId;
        BazaPodataka baza = new BazaPodataka();

        public NarudzbaPrikaz(int id)
        {
            InitializeComponent();
            korisnikId = id;
        }

        private void NarudzbaPrikaz_Load(object sender, EventArgs e)
        {
            BindingList<dbNarudžba> sveNarudzbe = baza.DohvatiMojeNarudzbe(korisnikId);

            foreach (var item in sveNarudzbe)
            {
                UgostiteljskiObjekt objekt = baza.DohvatiUgostiteljskiObjekt(item.ugostiteljski_obrt_id);
                uiPopisMojihNarudzbi.Controls.Add(new Narudzba(objekt.Naziv ,item.datum.ToString(), item.id_narudzbe));
            }
        }
    }
}
