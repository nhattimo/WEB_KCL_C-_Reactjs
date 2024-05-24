using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IProductCategoryRepository
    {
        Task<List<ProductCategory>> GetAllProductCategoriesAsync();
        Task<ProductCategory?> GetProductCategoryByIdAsync(int Id);
        Task<ProductCategory> CreateProductCategoryAsync(AddingProductCategory addingProductCategoryDto);
        Task<ProductCategory?> UpdateProductCategoryAsync(int Id, UpdatingProductCategory updatingProductCategoryDto);
        Task<ProductCategory?> DeleteProductCategoryAsync(int Id);
    }
}
