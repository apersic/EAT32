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
    
    public partial class dbObicniKorisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbObicniKorisnik()
        {
            this.dbNarudžba = new HashSet<dbNarudžba>();
            this.dbRezervacija = new HashSet<dbRezervacija>();
            this.dbPretplata = new HashSet<dbPretplata>();
        }
    
        public int id_obicnog_korisnika { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
    
        public virtual dbKorisnickiRacun dbKorisnickiRacun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbNarudžba> dbNarudžba { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbRezervacija> dbRezervacija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbPretplata> dbPretplata { get; set; }
    }
}