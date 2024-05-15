using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IProductCategoryRepository
    {
        Task<List<ProductCatogory>> GetAllProductCategoriesAsync();
        Task<ProductCatogory?> GetProductCategoryByIdAsync(int Id);
        Task<ProductCatogory> CreateProductCategoryAsync(AddingProductCategory addingProductCategoryDto);
        Task<ProductCatogory?> UpdateProductCategoryAsync(int Id, UpdatingProductCategory updatingProductCategoryDto);
        Task<ProductCatogory?> DeleteProductCategoryAsync(int Id);
    }
}
