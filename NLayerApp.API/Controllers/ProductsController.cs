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
        private readonly IProductService _productService;
        private readonly IMapper? _mapper;
        
        public ProductsController(IProductService productService, IMapper? mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        //GET api/Products/GetProductsWithCategory
        //[HttpGet("GetProductsWithCategory")]
        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithCategory()
        {
            return CreateActionResult(await _productService.GetProductsWithCategoryAsync());
        }

        //GET api/Products/
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService?.GetAllAsync();
            var productsDto = _mapper?.Map<List<ProductDto>>(products.ToList());

            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
        }

        //GET api/Products/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int? id)
        {
            var product = await _productService.GetByIdAsync(id);
            var productDto = _mapper.Map<ProductDto>(product);

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDto));
        }

        //POST api/Products/
        [HttpPost]
        public async Task<IActionResult> Add(ProductDto productDto)
        {
            var product = await _productService.AddAsync(_mapper.Map<Product>(productDto));
            var productDtoMap = _mapper.Map<ProductDto>(product);

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDtoMap));
        }

        //PUT api/Products/
        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto)
        {
            await _productService.UpdateAsync(_mapper.Map<Product>(productUpdateDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        //DELETE api/Products/id
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int? id)
        {
            var product = await _productService.GetByIdAsync(id);
            await _productService.RemoveAsync(product);

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(204));
        }
    }
}
