﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBEntity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class B1OnlineEntities : DbContext
    {
        public B1OnlineEntities()
            : base("name=B1OnlineEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CauHoi> CauHois { get; set; }
        public virtual DbSet<ChuDe> ChuDes { get; set; }
        public virtual DbSet<DeThi> DeThis { get; set; }
        public virtual DbSet<Doc> Docs { get; set; }
        public virtual DbSet<Nghe> Nghes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
