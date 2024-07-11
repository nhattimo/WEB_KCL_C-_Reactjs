using AutoMapper;
using KCL_Web.Server.Dtos.Post;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using KCL_Web.Server.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace KCL_Web.Server.Repository
{
    public class PostRepository : IPostRepostitory
    {
        private readonly KclinicKclWebsiteContext _context;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        string[] allowedFileExtentions = [".jpg", ".jpeg", ".png"];
        public PostRepository( KclinicKclWebsiteContext context, IMapper mapper, IFileService fileService)
        {
            _context = context;
            _mapper = mapper;
            _fileService = fileService;
        }
        public async Task<Post> CreatePostAsync(AddingPost addingPostDto)
        {
            
                if (addingPostDto.Image != null)
                {
                    addingPostDto.ImageUrl = await _fileService.SaveFileAsync(addingPostDto.Image, allowedFileExtentions);
                }
                var post = _mapper.Map<Post>(addingPostDto);
                await _context.Posts.AddAsync(post);
                await _context.SaveChangesAsync(); ;
                return post;
        }

        public async Task<Post?> DeletePostAsync(int Id)
        {
            
            var existingPost = await _context.Posts.FirstOrDefaultAsync(p => p.PostId == Id);
            if (existingPost == null)
            {
                return null;
            }
            if (!string.IsNullOrEmpty(existingPost.ImageUrl) && existingPost.ImageUrl != null && File.Exists(existingPost.ImageUrl))
            {

                _fileService.DeleteFile($"{existingPost.ImageUrl}");
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
            Console.WriteLine("id"+ " "+ Id);
        

            if (updatedPostDto.Image != null)
            {
                string ImageName = await _fileService.SaveFileAsync(updatedPostDto.Image, allowedFileExtentions);
                updatedPostDto.ImageUrl = ImageName;

                if (!string.IsNullOrEmpty(post.ImageUrl) && post.ImageUrl != null && File.Exists(post.ImageUrl))
                {
                    _fileService.DeleteFile($"{post.ImageUrl}");
                }
            }
      
            post.Title = updatedPostDto.Title;
            post.IntroContent = updatedPostDto.IntroContent;
            post.Content = updatedPostDto.Content;
            post.ImageUrl = updatedPostDto.ImageUrl;
            post.PostDate = updatedPostDto.PostDate;
            post.AuthorName = updatedPostDto.AuthorName;
            post.CategoryId = updatedPostDto.CategoryId;
            post.UpdatedDate = updatedPostDto.UpdatedDate;
            post.Status = updatedPostDto.Status;
            await _context.SaveChangesAsync();

            //foreach (PropertyInfo property in typeof(UpdatedPost).GetProperties())
            //{
            //    Console.WriteLine($"{property.Name}: {property.GetValue(updatedPostDto)}");
            //}
            return post;

        }
    }
}
