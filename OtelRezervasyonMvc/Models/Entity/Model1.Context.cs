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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbOtelEntities : DbContext
    {
        public DbOtelEntities()
            : base("name=DbOtelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Hakkimda> Tbl_Hakkimda { get; set; }
        public virtual DbSet<Tbl_Hizmetlerimiz> Tbl_Hizmetlerimiz { get; set; }
        public virtual DbSet<Tbl_İletisim> Tbl_İletisim { get; set; }
        public virtual DbSet<Tbl_Mesajlar> Tbl_Mesajlar { get; set; }
        public virtual DbSet<Tbl_YeniKayit> Tbl_YeniKayit { get; set; }
        public virtual DbSet<Tbl_Misafir> Tbl_Misafir { get; set; }
        public virtual DbSet<Tbl_Rezarvasyon> Tbl_Rezarvasyon { get; set; }
        public virtual DbSet<Tbl_Mesaj2> Tbl_Mesaj2 { get; set; }
        public virtual DbSet<Tbl_Oda> Tbl_Oda { get; set; }
        public virtual DbSet<Tbl_Ekibimiz> Tbl_Ekibimiz { get; set; }
        public virtual DbSet<Tbl_OnRezervasyon> Tbl_OnRezervasyon { get; set; }
    }
}
