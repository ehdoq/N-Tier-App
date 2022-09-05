namespace NLayerApp.Core.DTOs.EntityDtos
{
    public class ProductsWithCategoryDto : ProductDto
    {
        public CategoryDto? Category { get; set; }
    }
}
