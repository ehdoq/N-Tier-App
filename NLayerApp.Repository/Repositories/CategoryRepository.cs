using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Entities.Concrete;
using NLayerApp.Core.Repositories;
using NLayerApp.Repository.AppDBContext;

namespace NLayerApp.Repository.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }

        public async Task<Category>? GetSingleCategoryByIdWithProductsAsync(int? categoryId)
        {
            return await _appDbContext.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }
    }
}
