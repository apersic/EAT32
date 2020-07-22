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
    
    public partial class dbUgostiteljskiObjekt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbUgostiteljskiObjekt()
        {
            this.dbNarudžba = new HashSet<dbNarudžba>();
            this.dbRezervacija = new HashSet<dbRezervacija>();
            this.dbPonuda = new HashSet<dbPonuda>();
            this.dbPretplata = new HashSet<dbPretplata>();
        }
    
        public int id_ugostiteljskog_obrta { get; set; }
        public string naziv { get; set; }
        public Nullable<System.TimeSpan> radno_vrijeme_pocetak { get; set; }
        public Nullable<System.TimeSpan> radno_vrijeme_kraj { get; set; }
    
        public virtual dbKorisnickiRacun dbKorisnickiRacun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbNarudžba> dbNarudžba { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbRezervacija> dbRezervacija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbPonuda> dbPonuda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbPretplata> dbPretplata { get; set; }
    }
}
