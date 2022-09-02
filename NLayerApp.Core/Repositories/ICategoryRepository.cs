using NLayerApp.Core.Entities.Concrete;

namespace NLayerApp.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category>? GetSingleCategoryByIdWithProductsAsync(int? categoryId);
    }
}
