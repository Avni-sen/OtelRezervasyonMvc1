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
    
    public partial class Tbl_Rezarvasyon
    {
        public int RezervasyonId { get; set; }
        public Nullable<int> Misafir { get; set; }
        public Nullable<System.DateTime> GirisTarih { get; set; }
        public Nullable<System.DateTime> CikisTarih { get; set; }
        public string KisiSayisi { get; set; }
        public Nullable<int> Oda { get; set; }
        public string RezervasyonAdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Aciklama { get; set; }
        public Nullable<int> Durum { get; set; }
        public Nullable<int> Kisi1 { get; set; }
        public Nullable<int> Kisi2 { get; set; }
        public Nullable<int> Kisi3 { get; set; }
    
        public virtual Tbl_Misafir Tbl_Misafir { get; set; }
        public virtual Tbl_Oda Tbl_Oda { get; set; }
    }
}