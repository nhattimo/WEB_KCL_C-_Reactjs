using KCL_Web.Server.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. (Thêm dịch vụ vào container)

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// đăng ký một đối tượng DbContext của Entity Framework Core vào container dịch vụ của ứng dụng ASP.NET Core
builder.Services.AddDbContext<KclinicKclWebsiteContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBWebKCLGroup"));
});

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
