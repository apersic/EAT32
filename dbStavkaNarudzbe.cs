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
    
    public partial class dbStavkaNarudzbe
    {
        public int artikl_id { get; set; }
        public int narudzba_id { get; set; }
        public int kolicina { get; set; }
        public decimal popust { get; set; }
        public int id_stavke_narudzbe { get; set; }
    
        public virtual dbArtikl dbArtikl { get; set; }
        public virtual dbNarudžba dbNarudžba { get; set; }
    }
}