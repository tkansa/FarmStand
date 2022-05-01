using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmStand.Models
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Produce> Produce { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit", CategoryDescription = "Sweet Fruits" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Root Vegetables", CategoryDescription = "Vegetables " });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seeded Vegetables", CategoryDescription = "Savory Fruits" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Root Vegetables", CategoryDescription = "Underground Produce" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Herbs", CategoryDescription = "Aromatic Leaves" });

            modelBuilder.Entity<Produce>().HasData(new Produce { ProduceId = 1, Name = "Strawberries", Price = 4.99m, IsProduceOfTheWeek = false, CategoryId = 1, ImageUrl = "" });
            modelBuilder.Entity<Produce>().HasData(new Produce { ProduceId = 2, Name = "Onions", Price = 1.99m, IsProduceOfTheWeek = false, CategoryId = 2, ImageUrl = "" });
            modelBuilder.Entity<Produce>().HasData(new Produce { ProduceId = 3, Name = "Cucumbers", Price = 3.99m, IsProduceOfTheWeek = true, CategoryId = 3, ImageUrl = "" });
        }
    }
}
