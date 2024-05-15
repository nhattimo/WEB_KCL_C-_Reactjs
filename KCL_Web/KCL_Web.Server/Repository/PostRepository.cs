using AutoMapper;
using KCL_Web.Server.Dtos.Post;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class PostRepository : IPostRepostitory
    {
        private readonly KclinicKclWebsiteContext _context;
        private readonly IMapper _mapper;
        public PostRepository(KclinicKclWebsiteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Post> CreatePostAsync(AddingPost addingPostDto)
        {
            var post = _mapper.Map<Post>(addingPostDto);
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<Post?> DeletePostAsync(int Id)
        {
            var existingPost = await _context.Posts.FirstOrDefaultAsync(p => p.PostId == Id);
            if (existingPost == null)
            {
                return null;
            }
            _context.Posts.Remove(existingPost);
            await _context.SaveChangesAsync();
            return existingPost;
        }

        public async Task<List<Post>> GetAllPostsAsync()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<Post?> GetPostByIdAsync(int Id)
        {
            return await _context.Posts.FirstOrDefaultAsync(p => p.PostId == Id);
        }

        public async Task<Post?> UpdatePostAsync(int Id, UpdatedPost updatedPostDto)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(p => p.PostId == Id);
            if (post == null)
            {
                return null;
            }
            post.Title = updatedPostDto.Title;
            post.Content = updatedPostDto.Content;
            post.ImageUrl = updatedPostDto.ImageUrl;
            post.PostDate = updatedPostDto.PostDate;
            post.AuthorName = updatedPostDto.AuthorName;
            post.CategoryId = updatedPostDto.CategoryId;
            post.UpdatedDate = updatedPostDto.UpdatedDate;
            post.Status = updatedPostDto.Status;
            await _context.SaveChangesAsync();
            return post;
        }
    }
}
