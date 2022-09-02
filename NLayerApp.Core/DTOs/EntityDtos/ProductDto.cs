namespace NLayerApp.Core.DTOs.EntityDtos
{
    public class ProductDto : BaseEntityDto
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
