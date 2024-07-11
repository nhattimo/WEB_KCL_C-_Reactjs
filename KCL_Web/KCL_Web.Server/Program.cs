using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Mappers;
using KCL_Web.Server.Models;
using KCL_Web.Server.Repository;
using KCL_Web.Server.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Net;
using System.Security.Cryptography;
using System.Text;

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


Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseKestrel(options =>
                {
                    options.Listen(IPAddress.Any, 5000); // Hoặc port bạn muốn sử dụng
                });
            });

// 2.Đăng ký DbContext của Entity Framework Core:
// Bạn đang đăng ký một đối tượng DbContext của Entity Framework Core 
// vào container dịch vụ của ứng dụng ASP.NET Core, sử dụng cơ sở dữ liệu SQL Server.
var HastConnet = builder.Configuration.GetConnectionString("DBWebKCLGroup");
byte[] encryptedBytes = Convert.FromBase64String(HastConnet);
byte[] plainBytes = ProtectedData.Unprotect(encryptedBytes, null, DataProtectionScope.CurrentUser);
builder.Services.AddDbContext<KclinicKclWebsiteContext>(options =>
{
    options.UseSqlServer(Encoding.UTF8.GetString(plainBytes));
});

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 12;
})
.AddEntityFrameworkStores<KclinicKclWebsiteContext>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme =
    options.DefaultChallengeScheme =
    options.DefaultForbidScheme =
    options.DefaultScheme =
    options.DefaultSignInScheme =
    options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        ClockSkew = TimeSpan.Zero
    };
});

// 3.Đăng ký repository:
// Đây là cách đăng ký một repository (StockRepository) 
// với một interface (IStockRepository) trong container dịch vụ. 
// Điều này giúp giảm bớt sự phụ thuộc giữa các lớp và tạo điều kiện cho việc sử dụng Dependency Injection.
builder.Services.AddTransient<IFileService, FileService>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();

builder.Services.AddScoped<IStockRepository, StockRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();

builder.Services.AddScoped<INavigationRepository, NavigationRepository>();
builder.Services.AddScoped<INavListRepository, NavListRepository>();

builder.Services.AddScoped<IRoleRepository, RoleRepository>();

builder.Services.AddScoped<IBannerRepository, BannerRepository>();
//ProductCategoryRepository
builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
//ProuductRepository
builder.Services.AddScoped<IProductRepository, ProductRepository>();
//PostingCategoryRepository
builder.Services.AddScoped<IPostingCategoryRepository, PostingCategoryRepository>();
//PostRepository
builder.Services.AddScoped<IPostRepostitory, PostRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
builder.Services.AddScoped<ITokenService, TokenService>();





// Tạo ra một đối tượng ứng dụng (app) từ đối tượng builder đã được xây dựng trước đó.
// Điều này là cần thiết để có thể tiếp tục cấu hình và chạy ứng dụng
var app = builder.Build();
app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});

// Serve static files from the dist folder

var compositeFileProvider = new CompositeFileProvider(
    new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "wwwroot", "upload")),
    new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "wwwroot", "dist", "img"))
);


app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = compositeFileProvider,
    RequestPath = "/api/img"
});

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

//
app.UseAuthentication();
app.UseAuthorization();

// UseAuthorization() được sử dụng để kích hoạt middleware xác thực và phân quyền.
//app.UseAuthorization();

// MapControllers() được sử dụng để ánh xạ các yêu cầu tới các API Controller.
app.MapControllers();

// MapFallbackToFile("/index.html") được sử dụng để ánh xạ các yêu cầu không phù hợp 
//(không tìm thấy đường dẫn) tới một tập tin index.html, 
//có thể là trang web SPA (Single Page Application) hoặc bất kỳ trang nào bạn muốn hiển thị khi không tìm thấy đường dẫn nào khớp.
app.MapFallbackToFile("/index.html");

app.Run();
