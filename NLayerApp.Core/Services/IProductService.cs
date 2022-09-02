using NLayerApp.Core.DTOs.CustomResponseDto;
using NLayerApp.Core.DTOs.EntityDtos;

namespace NLayerApp.Core.Services
{
    public interface IProductService
    {
        Task<CustomResponseDto<List<ProductsWithCategotyDto>>>? GetProductsWithCategoryAsync();
    }
}
