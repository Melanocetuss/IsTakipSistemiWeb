﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcFirmaCagri.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbisTakipEntities : DbContext
    {
        public DbisTakipEntities()
            : base("name=DbisTakipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_ADMIN> tbl_ADMIN { get; set; }
        public virtual DbSet<tbl_Cagri> tbl_Cagri { get; set; }
        public virtual DbSet<tbl_Departmanlar> tbl_Departmanlar { get; set; }
        public virtual DbSet<tbl_Firmalar> tbl_Firmalar { get; set; }
        public virtual DbSet<tbl_GorevDetaylar> tbl_GorevDetaylar { get; set; }
        public virtual DbSet<tbl_Gorevler> tbl_Gorevler { get; set; }
        public virtual DbSet<tbl_Personeler> tbl_Personeler { get; set; }
        public virtual DbSet<tbl_CagriDetay> tbl_CagriDetay { get; set; }
        public virtual DbSet<tbl_Mesajlar> tbl_Mesajlar { get; set; }
    
        public virtual ObjectResult<GetGelenMesajlar_Result> GetGelenMesajlar(Nullable<int> aliciID)
        {
            var aliciIDParameter = aliciID.HasValue ?
                new ObjectParameter("AliciID", aliciID) :
                new ObjectParameter("AliciID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetGelenMesajlar_Result>("GetGelenMesajlar", aliciIDParameter);
        }
    }
}
