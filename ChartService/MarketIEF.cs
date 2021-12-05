// "//-----------------------------------------------------------------------".
// <copyright file="ChartService.cs" company="">
// Copyright (c) All rights reserved.
// </copyright>
// "//-----------------------------------------------------------------------".

using System.Data.Entity;

namespace ChartService
{
    public partial class MarketIEF : DbContext
    {
        public MarketIEF()
            : base("name=MarketIEF")
        {
        }

        public virtual DbSet<marketI> marketIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<marketI>()
                .Property(e => e.Strategy)
                .IsUnicode(false);
        }
    }
}
