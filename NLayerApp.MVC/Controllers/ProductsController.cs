using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLayerApp.Core.DTOs.EntityDtos;
using NLayerApp.Core.Entities.Concrete;
using NLayerApp.Core.Services;

namespace NLayerApp.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetProductsWithCategoryAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Save()
        {
            var categories = await _categoryService.GetAllAsync();
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                await _productService.AddAsync(_mapper.Map<Product>(productDto));
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var categories = await _categoryService.GetAllAsync();
                var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());
                ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");
                return View();
            }
        }
    }
}
