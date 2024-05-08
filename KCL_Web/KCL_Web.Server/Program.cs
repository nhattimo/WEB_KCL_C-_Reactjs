using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using KCL_Web.Server.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1.Add services to the container. (Thêm dịch vụ vào container)
// Ở đây, bạn đang thêm các dịch vụ cần thiết cho việc xây dựng API, bao gồm đăng ký Swagger/OpenAPI để tạo tài liệu API.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    });



// 2.Đăng ký DbContext của Entity Framework Core:
// Bạn đang đăng ký một đối tượng DbContext của Entity Framework Core 
// vào container dịch vụ của ứng dụng ASP.NET Core, sử dụng cơ sở dữ liệu SQL Server.
builder.Services.AddDbContext<KclinicKclWebsiteContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBWebKCLGroup"));
});


// 3.Đăng ký repository:
// Đây là cách đăng ký một repository (StockRepository) 
// với một interface (IStockRepository) trong container dịch vụ. 
// Điều này giúp giảm bớt sự phụ thuộc giữa các lớp và tạo điều kiện cho việc sử dụng Dependency Injection.
builder.Services.AddScoped<IStockRepository, StockRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<INavigationRepository, NavigationRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();

// Tạo ra một đối tượng ứng dụng (app) từ đối tượng builder đã được xây dựng trước đó.
// Điều này là cần thiết để có thể tiếp tục cấu hình và chạy ứng dụng
var app = builder.Build();

// Middleware này được sử dụng để chuyển hướng yêu cầu đến các tệp mặc định trong thư mục gốc của ứng dụng (ví dụ: index.html, default.html, ...).
// Nếu người dùng truy cập trang web mà không chỉ định tên tệp cụ thể trong URL, thì middleware này sẽ tự động chuyển hướng yêu cầu đến tệp mặc định được cấu hình.
app.UseDefaultFiles();


// Middleware này được sử dụng để phục vụ các tệp tĩnh như hình ảnh, CSS, JavaScript, vv.
// Khi một yêu cầu được thực hiện, middleware này sẽ kiểm tra xem nếu có một tệp tương ứng trong thư mục được cấu hình, và nếu có, nó sẽ trả về tệp đó cho người dùng.
// Điều này cho phép ứng dụng phục vụ các tệp tĩnh mà không cần phải thông qua các controller hoặc routes được cấu hình khác


// 4.Configure the HTTP request pipeline (Cấu hình pipeline của HTTP request)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// UseHttpsRedirection() chuyển hướng các yêu cầu HTTP sang HTTPS.
app.UseHttpsRedirection();

// UseAuthorization() được sử dụng để kích hoạt middleware xác thực và phân quyền.
app.UseAuthorization();

// MapControllers() được sử dụng để ánh xạ các yêu cầu tới các API Controller.
app.MapControllers();

// MapFallbackToFile("/index.html") được sử dụng để ánh xạ các yêu cầu không phù hợp 
//(không tìm thấy đường dẫn) tới một tập tin index.html, 
//có thể là trang web SPA (Single Page Application) hoặc bất kỳ trang nào bạn muốn hiển thị khi không tìm thấy đường dẫn nào khớp.
app.MapFallbackToFile("/index.html");

app.Run();
