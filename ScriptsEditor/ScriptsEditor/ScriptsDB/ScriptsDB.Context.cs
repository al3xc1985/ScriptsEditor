﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScriptsEditor.ScriptsDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ScriptsDB : DbContext
    {
        public ScriptsDB()
            : base("name=ScriptsDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<creature_ai_scripts> creature_ai_scripts { get; set; }
        public virtual DbSet<creature_ai_summons> creature_ai_summons { get; set; }
        public virtual DbSet<creature_ai_texts> creature_ai_texts { get; set; }
    }
}
