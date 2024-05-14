using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<Portfolio> CreateAsync(Portfolio portfolio);
        Task<Portfolio> DeletePortfolio(AppUser appUser, string symbol);
    }
}