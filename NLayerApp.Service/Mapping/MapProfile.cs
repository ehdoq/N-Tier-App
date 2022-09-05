using AutoMapper;
using NLayerApp.Core.DTOs.EntityDtos;
using NLayerApp.Core.Entities.Concrete;

namespace NLayerApp.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductsWithCategoryDto>();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryWithProductsDto>();
        }
    }
}
