using AutoMapper;
using NLayerApp.Core.DTOs.CustomResponseDto;
using NLayerApp.Core.DTOs.EntityDtos;
using NLayerApp.Core.Entities.Concrete;
using NLayerApp.Core.Repositories;
using NLayerApp.Core.Services;
using NLayerApp.Core.UnitOfWorks;

namespace NLayerApp.Service.Services
{
    public class ProductServiceWithNoCaching : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductServiceWithNoCaching(IRepository<Product> repository, 
                                           IUnitOfWork unitOfWork, 
                                           IProductRepository productRepository,
                                           IMapper mapper) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<ProductsWithCategoryDto>>>? GetProductsWithCategoryAsync()
        {
            var products = await _productRepository.GetProductsWithCategoryAsync();
            var productsDto = _mapper.Map<List<ProductsWithCategoryDto>>(products);

            return CustomResponseDto<List<ProductsWithCategoryDto>>.Success(200, productsDto);
        }
    }
}
