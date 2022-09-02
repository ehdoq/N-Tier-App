using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Entities.Concrete;

namespace NLayerApp.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
            (
                new Product() { Id = 1, CategoryId = 1, Name = "Kurşun kalem", Price = 100, Stock = 10, CreatedDate = DateTime.Now },
                new Product() { Id = 2, CategoryId = 1, Name = "Dolma kalem", Price = 200, Stock = 20, CreatedDate = DateTime.Now },
                new Product() { Id = 3, CategoryId = 1, Name = "Uçlu kalem", Price = 300, Stock = 30, CreatedDate = DateTime.Now },
                new Product() { Id = 4, CategoryId = 2, Name = "Roman", Price = 400, Stock = 40, CreatedDate = DateTime.Now },
                new Product() { Id = 5, CategoryId = 2, Name = "Bilim kurgu", Price = 500, Stock = 50, CreatedDate = DateTime.Now },
                new Product() { Id = 6, CategoryId = 2, Name = "Gerilim", Price = 600, Stock = 60, CreatedDate = DateTime.Now },
                new Product() { Id = 7, CategoryId = 3, Name = "Çizgili defter", Price = 700, Stock = 70, CreatedDate = DateTime.Now },
                new Product() { Id = 8, CategoryId = 3, Name = "Kareli defter", Price = 800, Stock = 80, CreatedDate = DateTime.Now },
                new Product() { Id = 9, CategoryId = 3, Name = "Çizgisiz defter", Price = 900, Stock = 90, CreatedDate = DateTime.Now }
            );
        }
    }
}
