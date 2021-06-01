using LaraVi.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaraVi.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public IConfiguration Configuration { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Products
            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Name = "Nane",
                   BestBefore = new Date(2020, 02, 29),
                   DateManifactured = new Date(2019, 11, 29),
                   Price = 198,
                   CategoryID = 1,
                   CategoryName = "Zacini",
                   Manifacturer = "Po Doma",
                   Discription = "Nane moze da se upotrebuva i kako caj i kako zacin",
                   Shipping = "Koga ke mozam",
                   PhotoURL = "12x12x20",
                   SoldItems = 50,
                   Rating = 4.3,
                   DateAdded = DateTime.Now,
                   CountryOFOrigin = "Kurgistan",
                   Popularity = false,
                   ByWeight = true,
                   ByPeace = false,
                   UserID = 1
               });
            #endregion
            #region Category
            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Zacini"

            });
            #endregion
            base.OnModelCreating(modelBuilder);
        }

    }
}
