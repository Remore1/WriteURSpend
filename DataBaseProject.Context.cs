﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WriteUrSpend
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WriteUrSpendEntities : DbContext
    {
        public WriteUrSpendEntities()
            : base("name=WriteUrSpendEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CurrentBalance> CurrentBalance { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<CategoriesBuy> CategoriesBuy { get; set; }
        public virtual DbSet<CategoryIncome> CategoryIncome { get; set; }
        public virtual DbSet<HistoryBuy> HistoryBuy { get; set; }
        public virtual DbSet<HistoryIncome> HistoryIncome { get; set; }
    }
}
