using KCL_Web.Server.Dtos.Post;
using KCL_Web.Server.Dtos.Product;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IPostRepostitory
    {
        Task<List<Post>> GetAllPostsAsync();
        Task<Post?> GetPostByIdAsync(int Id);
        Task<Post> CreatePostAsync(AddingPost addingPostDto);
        Task<Post?> UpdatePostAsync(int Id, UpdatedPost updatedPostDto);
        Task<Post?> DeletePostAsync(int Id);

    }
}
