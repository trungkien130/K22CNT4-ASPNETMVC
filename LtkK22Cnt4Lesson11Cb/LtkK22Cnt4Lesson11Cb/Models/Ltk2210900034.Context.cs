﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LtkK22Cnt4Lesson11Cb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LtkK22Cnt4Lesson11CbEntities1 : DbContext
    {
        public LtkK22Cnt4Lesson11CbEntities1()
            : base("name=LtkK22Cnt4Lesson11CbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LtkCatagory> LtkCatagory { get; set; }
        public virtual DbSet<LtkProduct> LtkProduct { get; set; }
    }
}