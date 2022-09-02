using NLayerApp.Core.Entities.Concrete;

namespace NLayerApp.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>>? GetProductsWithCategoryAsync();
    }
}
