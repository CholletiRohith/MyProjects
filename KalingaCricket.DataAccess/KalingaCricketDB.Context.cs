﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KalingaCricket.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KalingaCricketDBEntities1 : DbContext
    {
        public KalingaCricketDBEntities1()
            : base("name=KalingaCricketDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Player_Team> Player_Team { get; set; }
        public virtual DbSet<tbl_Player> tbl_Player { get; set; }
        public virtual DbSet<tbl_Team> tbl_Team { get; set; }
        public virtual DbSet<tbl_Type> tbl_Type { get; set; }
    }
}
