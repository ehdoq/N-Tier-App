using NLayerApp.Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace NLayerApp.Core.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        //[ForeignKey("Category_Id")] = eğer farklı isim verirsek bu attribute'ü kullanırız. 
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ProductFeature? ProductFeature { get; set; }
    }
}
