using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly KclinicKclWebsiteContext _context;

        public CommentRepository(KclinicKclWebsiteContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<Comment?> GetByIdAsync(int id)
        {
            return await _context.Comments.FindAsync(id);
        }

    }
}