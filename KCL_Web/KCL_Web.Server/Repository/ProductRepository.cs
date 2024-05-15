using AutoMapper;
using KCL_Web.Server.Dtos.Product;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly KclinicKclWebsiteContext _context;
        private readonly IMapper _mapper;
        public ProductRepository(KclinicKclWebsiteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Product> CreateProductAsync(AddingProduct addingProductDto)
        {
            var product= _mapper.Map<Product>(addingProductDto);
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product?> DeleteProductAsync(int Id)
        {
            var existingProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == Id);
            if (existingProduct == null)
            {
                return null;
            }
            _context.Products.Remove(existingProduct);
            await _context.SaveChangesAsync();
            return existingProduct;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int Id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<Product?> UpdateProductAsync(int Id, UpdatedProduct updatedProductDto)
        {
            var product= await _context.Products.FirstOrDefaultAsync(p => p.Id == Id);
            if (product == null)
            {
                return null;
            }
            product.Name = updatedProductDto.Name;
            product.AddedTime = updatedProductDto.AddedTime;
            product.UpdatedTime = updatedProductDto.UpdatedTime;
            product.Status = updatedProductDto.Status;
            product.CatogoryId = updatedProductDto.CatogoryId;
            product.UrlImage = updatedProductDto.UrlImage;
            product.Description = updatedProductDto.Description;
            product.AccountId = updatedProductDto.AccountId;
            await _context.SaveChangesAsync();

            return product;
        }
    }
}
