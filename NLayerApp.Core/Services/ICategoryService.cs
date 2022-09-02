using NLayerApp.Core.DTOs.CustomResponseDto;
using NLayerApp.Core.DTOs.EntityDtos;
using NLayerApp.Core.Entities.Concrete;

namespace NLayerApp.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<CustomResponseDto<CategoryWithProductsDto>>? GetSingleCategoryByIdWithProductsAsync(int? categoryId);
    }
}
