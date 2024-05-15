using KCL_Web.Server.Dtos.Product;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int Id);
        Task<Product> CreateProductAsync(AddingProduct addingProductDto);
        Task<Product?> UpdateProductAsync(int Id, UpdatedProduct updatedProductDto);
        Task<Product?> DeleteProductAsync(int Id);
    }
}
