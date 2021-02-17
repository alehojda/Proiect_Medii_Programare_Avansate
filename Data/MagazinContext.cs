using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ale_Hojda.Models;

namespace Ale_Hojda.Data
{
    public class MagazinContext: DbContext
    {
        public MagazinContext(DbContextOptions<MagazinContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Store>().ToTable("Store");
            modelBuilder.Entity<Restaurant>().ToTable("Restaurant");
        }
    }

}
