using BlazorCodeFirst.Shared.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace BlazorCodeFirst.Server.Data
{
    public class OrderDBContext : DbContext
    {
        public OrderDBContext(DbContextOptions options) : base(options)
        {

        }
        public OrderDBContext() : base()
        {

        }

        public virtual DbSet<Dimension> Dimensions { get; set;  }
        public virtual DbSet<ElementType> ElementTypes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<State> States { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ElementType>().HasData(
                new ElementType() {Id= 1, ElementTypeName = "Doors", CreatedAt = DateTime.UtcNow, CreatedBy = 1 },
                new ElementType() {Id =2,  ElementTypeName = "Window", CreatedAt = DateTime.UtcNow, CreatedBy = 1 },
                new ElementType() {Id =3, ElementTypeName = "Table", CreatedAt = DateTime.UtcNow, CreatedBy = 1 });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("orderconnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
