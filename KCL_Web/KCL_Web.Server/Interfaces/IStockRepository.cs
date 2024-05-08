using KCL_Web.Server.Dtos.Stock;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Interfaces
{
    public interface IStockRepository
    {
        /*
        Lớp IStockRepository là một interface 
        được sử dụng để định nghĩa các phương thức 
        mà một repository của đối tượng Stock cần phải triển khai.

        Cụ thể, các phương thức được định nghĩa trong interface này bao gồm:

        GetAllAsync: Lấy danh sách tất cả các đối tượng Stock từ cơ sở dữ liệu.
        GetByIdAsync: Lấy một đối tượng Stock từ cơ sở dữ liệu dựa trên ID.
        CreateAsync: Tạo một đối tượng Stock mới và thêm vào cơ sở dữ liệu.
        UpdateAsync: Cập nhật một đối tượng Stock hiện có trong cơ sở dữ liệu dựa trên ID với thông tin mới được cung cấp từ một đối tượng UpdateStockRequestDto.
        DeleteAsync: Xóa một đối tượng Stock từ cơ sở dữ liệu dựa trên ID.


        Interface này giúp tách biệt phần logic của repository 
        (thực hiện thao tác với cơ sở dữ liệu) khỏi lớp sử dụng nó. 
        Bằng cách này, các lớp sử dụng repository (StockRepository)
        có thể thực hiện các phương thức này mà không cần biết chi tiết về cách triển khai của chúng. 
        Điều này tạo ra một sự phân chia rõ ràng giữa các lớp và giảm thiểu sự phụ thuộc giữa chúng, 
        đồng thời tạo điều kiện cho việc sử dụng Dependency Injection để chèn các triển khai cụ thể 
        của repository vào các lớp khác nhau trong ứng dụng.
        */
        Task<List<Stock>> GetAllAsync();
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        Task<bool> StockExists(int id);


    }
}