using AutoMapper;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private  readonly KclinicKclWebsiteContext _context;
        private readonly IMapper _mapper;
        public ProductCategoryRepository(KclinicKclWebsiteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductCatogory> CreateProductCategoryAsync(AddingProductCategory addingProductCategoryDto)
        {

            var productCategory = _mapper.Map<ProductCatogory>(addingProductCategoryDto);
            await _context.ProductCatogories.AddAsync(productCategory);
            await _context.SaveChangesAsync();
            return productCategory;
        }

        public async Task<ProductCatogory?> DeleteProductCategoryAsync(int Id)
        {
            var existingProductCategory = await _context.ProductCatogories.FirstOrDefaultAsync(p => p.Id == Id);
            if (existingProductCategory == null)
            {
                return null;
            }
            _context.ProductCatogories.Remove(existingProductCategory);
            await _context.SaveChangesAsync();
            return existingProductCategory;
        }

        public async Task<List<ProductCatogory>> GetAllProductCategoriesAsync()
        {
            return await _context.ProductCatogories.ToListAsync();
        }

        public async Task<ProductCatogory?> GetProductCategoryByIdAsync(int Id)
        {
           return await _context.ProductCatogories.FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<ProductCatogory?> UpdateProductCategoryAsync(int Id, UpdatingProductCategory updatingProductCategoryDto)
        {
            var productCategory = await _context.ProductCatogories.FirstOrDefaultAsync(p => p.Id == Id);
            if(productCategory == null)
            {
                return null;
            }    
            productCategory.Name = updatingProductCategoryDto.Name;
            productCategory.Status = updatingProductCategoryDto.Status;
            productCategory.CreatedTime = updatingProductCategoryDto.CreatedTime;
            productCategory.UpdatedTime = updatingProductCategoryDto.UpdatedTime;
            productCategory.AccountId = updatingProductCategoryDto.AccountId;
            await _context.SaveChangesAsync();
            return productCategory;
        }
    }
}
