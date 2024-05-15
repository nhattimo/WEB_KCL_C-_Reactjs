using KCL_Web.Server.Dtos.PostCategory;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IPostingCategoryRepository
    {
        Task<List<PostingCategory>> GetAllPostingCategoriesAsync();
        Task<PostingCategory?> GetPostingCategoryByIdAsync(int Id);
        Task<PostingCategory> CreatePostingCategoryAsync(AddingPostCategory addingPostCategoryDto);
        Task<PostingCategory?> UpdatePostingCategoryAsync(int Id, UpdatedPostCategory updatedPostCategoryDto);
        Task<PostingCategory?> DeletePostingCategoryAsync(int Id);
    }
}
