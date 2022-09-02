﻿using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Entities.Concrete;

namespace NLayerApp.Repository.AppDBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductFeature>? ProductFeatures { get; set; }
    }
}