namespace NLayerApp.Core.DTOs.EntityDtos
{
    public class CategoryWithProductsDto : CategoryDto
    {
        public List<ProductDto>? Products { get; set; }
    }
}
