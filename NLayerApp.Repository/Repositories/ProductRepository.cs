using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Entities.Concrete;
using NLayerApp.Core.Repositories;
using NLayerApp.Repository.AppDBContext;

namespace NLayerApp.Repository.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
        public async Task<List<Product>>? GetProductsWithCategoryAsync()
        {
            return await _appDbContext.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
