﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATASET
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PRAKT3Entities : DbContext
    {
        public PRAKT3Entities()
            : base("name=PRAKT3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<INGREDIENTS> INGREDIENTS { get; set; }
        public virtual DbSet<SUSHI> SUSHI { get; set; }
        public virtual DbSet<SUSHI_STORE> SUSHI_STORE { get; set; }
    }
}
