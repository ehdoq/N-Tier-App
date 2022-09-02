namespace NLayerApp.Core.DTOs.EntityDtos
{
    public class ProductsWithCategotyDto : ProductDto
    {
        public CategoryDto? Category { get; set; }
    }
}
