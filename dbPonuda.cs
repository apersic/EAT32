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
    
    public partial class dbPonuda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbPonuda()
        {
            this.dbArtikl = new HashSet<dbArtikl>();
        }
    
        public int id_ponude { get; set; }
        public int ugostiteljski_obrt_id { get; set; }
        public string opis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbArtikl> dbArtikl { get; set; }
        public virtual dbUgostiteljskiObjekt dbUgostiteljskiObjekt { get; set; }
    }
}
