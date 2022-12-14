using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Entities.Abstract;
using NLayerApp.Core.Entities.Concrete;
using System.Reflection;

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

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                //item.Entity BaseEntity ise bir entityReference'a BaseEntity prop'larını ata
                if (item.Entity is BaseEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedDate = DateTime.Now;
                                break;
                            }

                        case EntityState.Modified:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                entityReference.UpdateDate = DateTime.Now;
                                break;
                            }
                    }
                }
            }
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                //item.Entity BaseEntity ise bir entityReference'a BaseEntity prop'larını ata
                if (item.Entity is BaseEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedDate = DateTime.Now;
                                break;
                            }

                        case EntityState.Modified:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                entityReference.UpdateDate = DateTime.Now;
                                break;
                            }
                    }
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.Entity<ProductFeature>().HasData
            (
                new ProductFeature() { Id = 1, Color = "Kırmızı", Height = 10, Width = 10, ProductId = 1 },
                new ProductFeature() { Id = 2, Color = "Mavi", Height = 10, Width = 10, ProductId = 2 },
                new ProductFeature() { Id = 3, Color = "Sarı", Height = 10, Width = 10, ProductId = 3 },
                new ProductFeature() { Id = 4, Color = "Kırmızı", Height = 30, Width = 20, ProductId = 4 },
                new ProductFeature() { Id = 5, Color = "Mavi", Height = 30, Width = 20, ProductId = 5 },
                new ProductFeature() { Id = 6, Color = "Sarı", Height = 30, Width = 20, ProductId = 6 },
                new ProductFeature() { Id = 7, Color = "Kırmızı", Height = 50, Width = 30, ProductId = 7 },
                new ProductFeature() { Id = 8, Color = "Mavi", Height = 50, Width = 30, ProductId = 8 },
                new ProductFeature() { Id = 9, Color = "Sarı", Height = 50, Width = 30, ProductId = 9 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
