using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.DTOs.CustomResponseDto;
using NLayerApp.Core.DTOs.EntityDtos;
using NLayerApp.Core.Entities.Concrete;
using NLayerApp.Core.Services;

namespace NLayerApp.API.Controllers
{
    public class ProductsController : CustomBaseController
    {
        private readonly IService<Product>? _productService;
        private readonly IMapper? _mapper;

        public ProductsController(IService<Product>? productService, IMapper? mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService?.GetAllAsync();
            var productsDto = _mapper?.Map<List<ProductDto>>(products.ToList());

            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int? id)
        {
            var product = await _productService.GetByIdAsync(id);
            var productDto = _mapper.Map<ProductDto>(product);

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDto));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductDto productDto)
        {
            var product = await _productService.AddAsync(_mapper.Map<Product>(productDto));
            var productDtoMap = _mapper.Map<ProductDto>(product);

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDtoMap));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto)
        {
            await _productService.UpdateAsync(_mapper.Map<Product>(productUpdateDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int? id)
        {
            var product = await _productService.GetByIdAsync(id);
            await _productService.RemoveAsync(product);

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(204));
        }
    }
}
