//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelRezervasyonMvc.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Oda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Oda()
        {
            this.Tbl_Rezarvasyon = new HashSet<Tbl_Rezarvasyon>();
        }
    
        public int OdaId { get; set; }
        public string OdaNo { get; set; }
        public string Kat { get; set; }
        public string Kapasite { get; set; }
        public string Aciklama { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> Durum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Rezarvasyon> Tbl_Rezarvasyon { get; set; }
    }
}
