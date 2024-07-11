using AutoMapper;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KCL_Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {

        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IMapper _mapper;
        public ProductCategoryController(IProductCategoryRepository productCategoryRepository, IMapper mapper)
        {

            this._productCategoryRepository = productCategoryRepository;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var productCategories = await _productCategoryRepository.GetAllProductCategoriesAsync();

            var productCategoriesDto = _mapper.Map<List<ProductCategoryDto>>(productCategories);
            return Ok(productCategories);
        }
        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> GetProductCategoryById([FromRoute] int Id)
        {
            var productCategory = await _productCategoryRepository.GetProductCategoryByIdAsync(Id);
            if (productCategory == null)
            {
                return NotFound();
            }
            var productCategoryDto = _mapper.Map<ProductCategoryDto>(productCategory);
            return Ok(productCategoryDto);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostProductCategory([FromBody] AddingProductCategory addingProductCategoryDto)
        {
            var productCategory = await _productCategoryRepository.CreateProductCategoryAsync(addingProductCategoryDto);
            var productCategoryDto = _mapper.Map<ProductCategoryDto>(productCategory);
            return CreatedAtAction("GetProductCategoryById", new { Id = productCategoryDto.Id }, productCategoryDto);
        }
        [Authorize]
        [HttpPut]
        [Route("{Id:int}")]
        public async Task<IActionResult> UpdateProductCategoryById([FromRoute] int Id, [FromBody] UpdatingProductCategory updatingProductCategoryDto)
        {
            var productCategory = await _productCategoryRepository.UpdateProductCategoryAsync(Id, updatingProductCategoryDto);
            if (productCategory == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ProductCategoryDto>(productCategory));
        }
        [Authorize]
        [HttpDelete]
        [Route("{Id:int}")]
        public async Task<IActionResult> DeleteProductCategory([FromRoute] int Id)
        {
            var productCatogory = await _productCategoryRepository.DeleteProductCategoryAsync(Id);
            if (productCatogory == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
