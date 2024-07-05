using AutoMapper;
using KCL_Web.Server.Dtos.PostCategory;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class PostingCategoryRepository : IPostingCategoryRepository
    {
        private readonly KclinicKclWebsiteContext _context;
        private readonly IMapper _mapper;
        public PostingCategoryRepository(KclinicKclWebsiteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<PostingCategory> CreatePostingCategoryAsync(AddingPostCategory addingPostCategoryDto)
        {
            var postingCategory = _mapper.Map<PostingCategory>(addingPostCategoryDto);
            await _context.PostingCategories.AddAsync(postingCategory);
            await _context.SaveChangesAsync();
            return postingCategory;
        }

        public async Task<PostingCategory?> DeletePostingCategoryAsync(int Id)
        {
            var existingPostingCategory = await _context.PostingCategories.FirstOrDefaultAsync(p => p.CategoryId == Id);
            if (existingPostingCategory == null)
            {
                return null;
            }
            _context.PostingCategories.Remove(existingPostingCategory);
            await _context.SaveChangesAsync();
            return existingPostingCategory;
        }

        public async Task<List<PostingCategory>> GetAllPostingCategoriesAsync()
        {
            return await _context.PostingCategories.ToListAsync();
        }

        public async Task<PostingCategory?> GetPostingCategoryByIdAsync(int Id)
        {

            return await _context.PostingCategories.FirstOrDefaultAsync(p => p.CategoryId == Id);
        }

        public async Task<PostingCategory?> UpdatePostingCategoryAsync(int Id, UpdatedPostCategory updatedPostCategoryDto)
        {
            var postingCategory = await _context.PostingCategories.FirstOrDefaultAsync(p => p.CategoryId == Id);
            if (postingCategory == null)
            {
                return null;
            }
            postingCategory.CategoryName = updatedPostCategoryDto.CategoryName;
            postingCategory.CreatedTime = updatedPostCategoryDto.UpdatedTime;
            postingCategory.Status = updatedPostCategoryDto.Status;
            //postingCategory.AppUserId = updatedPostCategoryDto.AccountId;
            await _context.SaveChangesAsync();
            return postingCategory;
        }
    }
}
