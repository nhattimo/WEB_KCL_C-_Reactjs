using AutoMapper;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly KclinicKclWebsiteContext _context;
        private readonly IMapper _mapper;
        public ProductCategoryRepository(KclinicKclWebsiteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductCategory> CreateProductCategoryAsync(AddingProductCategory addingProductCategoryDto)
        {

            var productCategory = _mapper.Map<ProductCategory>(addingProductCategoryDto);
            await _context.ProductCategorys.AddAsync(productCategory);
            await _context.SaveChangesAsync();
            return productCategory;
        }

        public async Task<ProductCategory?> DeleteProductCategoryAsync(int Id)
        {
            var existingProductCategory = await _context.ProductCategorys.FirstOrDefaultAsync(p => p.Id == Id);
            if (existingProductCategory == null)
            {
                return null;
            }
            _context.ProductCategorys.Remove(existingProductCategory);
            await _context.SaveChangesAsync();
            return existingProductCategory;
        }

        public async Task<List<ProductCategory>> GetAllProductCategoriesAsync()
        {
            return await _context.ProductCategorys.ToListAsync();
        }

        public async Task<ProductCategory?> GetProductCategoryByIdAsync(int Id)
        {
            return await _context.ProductCategorys.FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<ProductCategory?> UpdateProductCategoryAsync(int Id, UpdatingProductCategory updatingProductCategoryDto)
        {
            var productCategory = await _context.ProductCategorys.FirstOrDefaultAsync(p => p.Id == Id);
            if (productCategory == null)
            {
                return null;
            }
            productCategory.Name = updatingProductCategoryDto.Name;
            productCategory.Status = updatingProductCategoryDto.Status;
            productCategory.CreatedTime = updatingProductCategoryDto.CreatedTime;
            productCategory.UpdatedTime = updatingProductCategoryDto.UpdatedTime;
            productCategory.AppUserId = updatingProductCategoryDto.AccountId;
            await _context.SaveChangesAsync();
            return productCategory;
        }
    }
}
