//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrijavaRegistracija
{
    using System;
    using System.Collections.Generic;
    
    public partial class dbRezervacija
    {
        public int id_rezervacije { get; set; }
        public int ugostiteljski_obrt_id { get; set; }
        public int korisnik_id { get; set; }
        public int broj_stolova { get; set; }
    
        public virtual dbObicniKorisnik dbObicniKorisnik { get; set; }
        public virtual dbUgostiteljskiObjekt dbUgostiteljskiObjekt { get; set; }
    }
}
