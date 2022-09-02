namespace NLayerApp.Core.DTOs.EntityDtos
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
