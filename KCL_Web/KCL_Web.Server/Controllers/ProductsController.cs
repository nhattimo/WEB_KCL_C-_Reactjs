using AutoMapper;
using KCL_Web.Server.Dtos.Product;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KCL_Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductsController(IProductRepository productRepository, IMapper mapper)
        {

            this._productRepository = productRepository;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productRepository.GetAllProductsAsync();

            var productsDto = _mapper.Map<List<ProductDto>>(products);
            return Ok(productsDto);
        }
        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> GetProductById([FromRoute] int Id)
        {
            var product = await _productRepository.GetProductByIdAsync(Id);
            if (product == null)
            {
                return NotFound();
            }
            var productDto = _mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }
        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] AddingProduct addingProductDto)
        {
            var product = await _productRepository.CreateProductAsync(addingProductDto);
            var productDto = _mapper.Map<ProductDto>(product);
            return CreatedAtAction("GetProductById", new { Id = productDto.Id }, productDto);
        }
        [HttpPut]
        [Route("{Id:int}")]
        public async Task<IActionResult> UpdateProductById([FromRoute] int Id, [FromBody] UpdatedProduct updatedProductDto)
        {
            var product = await _productRepository.UpdateProductAsync(Id, updatedProductDto);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ProductDto>(product));
        }
        [HttpDelete]
        [Route("{Id:int}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int Id)
        {
            var product = await _productRepository.DeleteProductAsync(Id);
            if (product == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
