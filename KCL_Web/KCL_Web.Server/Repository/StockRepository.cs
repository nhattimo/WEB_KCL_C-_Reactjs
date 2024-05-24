using KCL_Web.Server.Dtos.Stock;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace KCL_Web.Server.Repository
{
    public class StockRepository : IStockRepository
    {
        /*
        Dependency Injection:
            - Lớp StockRepository được thiết lập với một dependency 
            vào đối tượng KclinicKclWebsiteContext thông qua constructor injection. 
            Điều này cho phép lớp Repository truy cập và tương tác với cơ sở dữ liệu thông qua context đã được cấp phát.

        Lớp StockRepository này là một phần của mô hình Repository Pattern 
        trong ứng dụng của bạn. Mục đích của lớp này là tương tác với cơ sở dữ liệu 
        để thực hiện các thao tác CRUD (Create, Read, Update, Delete) trên đối tượng Stock.11`  `   1   12
        */
        private readonly KclinicKclWebsiteContext _context;
        public StockRepository(KclinicKclWebsiteContext context)
        {
            _context = context;
        }

        public async Task<Stock> CreateAsync(Stock stockModel)
        {
            await _context.Stocks.AddAsync(stockModel);
            await _context.SaveChangesAsync();
            return stockModel;
        }

        public async Task<Stock?> DeleteAsync(int id)
        {
            var stockModel = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);
            if (stockModel == null)
                return null;

            _context.Stocks.Remove(stockModel);
            await _context.SaveChangesAsync();
            return stockModel;
        }

        public async Task<List<Stock>> GetAllAsync()
        {
            return await _context.Stocks.Include(c => c.Comments).ToListAsync();
        }

        public async Task<Stock?> GetByIdAsync(int id)
        {
            return await _context.Stocks.Include(c => c.Comments).FirstOrDefaultAsync(i => i.Id == id);

        }

        public Task<bool> StockExists(int id)
        {
            return _context.Stocks.AnyAsync(s => s.Id == id);
        }

        public async Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto)
        {
            var existingStock = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);
            if (existingStock == null)
            {
                return null;
            }
            existingStock.Synbol = stockDto.Synbol;
            existingStock.CompanyName = stockDto.CompanyName;
            existingStock.Purchase = stockDto.Purchase;
            existingStock.LastDiv = stockDto.LastDiv;
            existingStock.Industry = stockDto.Industry;
            existingStock.MarketCup = stockDto.MarketCup;

            await _context.SaveChangesAsync();
            return existingStock;
        }
    }
}