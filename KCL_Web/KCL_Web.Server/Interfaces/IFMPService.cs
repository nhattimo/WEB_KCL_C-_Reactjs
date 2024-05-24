using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IFMPService
    {
        Task<Stock> FindStockBySymbolAsync(string symbol);
    }
}