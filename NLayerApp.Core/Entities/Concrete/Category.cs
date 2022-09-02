using NLayerApp.Core.Entities.Abstract;

namespace NLayerApp.Core.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }

        //Navigation property
        public ICollection<Product>? Products { get; set; }
    }
}
