using AutoMapper;
using KCL_Web.Server.Dtos.Product;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using KCL_Web.Server.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace KCL_Web.Server.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly KclinicKclWebsiteContext _context;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        string[] allowedFileExtentions = [".jpg", ".jpeg", ".png"];
        public ProductRepository(KclinicKclWebsiteContext context, IMapper mapper, IFileService fileService)
        {
            _context = context;
            _mapper = mapper;
            _fileService = fileService;
        }

        public async Task<Product> CreateProductAsync(AddingProduct addingProductDto)
        {
            if (addingProductDto.Image != null)
            {
                addingProductDto.UrlImage = await _fileService.SaveFileAsync(addingProductDto.Image, allowedFileExtentions);
            }
        
            var product = _mapper.Map<Product>(addingProductDto);
            Console.WriteLine("CategoryId" + product.CategoryId);
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
            if (!string.IsNullOrEmpty(existingProduct.UrlImage) && existingProduct.UrlImage != null && File.Exists(existingProduct.UrlImage))
            {

                _fileService.DeleteFile($"{existingProduct.UrlImage}");
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
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == Id);
            if (product == null)
            {
                return null;
            }


            if (updatedProductDto.Image != null)
            {
                string ImageName = await _fileService.SaveFileAsync(updatedProductDto.Image, allowedFileExtentions);
                updatedProductDto.UrlImage = ImageName;
                if (!string.IsNullOrEmpty(product.UrlImage) && File.Exists(product.UrlImage))
                {
                    _fileService.DeleteFile($"{product.UrlImage}");
                }
            }
            product.Name = updatedProductDto.Name;
            product.IntroContent = updatedProductDto.IntroContent;
            product.AddedTime = updatedProductDto.AddedTime;
            product.UpdatedTime = updatedProductDto.UpdatedTime;
            product.Status = updatedProductDto.Status;
            product.CategoryId = updatedProductDto.CategoryId;
            product.UrlImage = updatedProductDto.UrlImage;
            product.Description = updatedProductDto.Description;
            //product.AppUserId = updatedProductDto.AccountId;

            await _context.SaveChangesAsync();
            return product;
        }
    }
}
