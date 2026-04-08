using Microsoft.EntityFrameworkCore;
using BookstoreManagement_CodeFirst.Models;

var builder = WebApplication.CreateBuilder(args);

// --- PHẦN 1: ĐĂNG KÝ DỊCH VỤ (SERVICES) ---

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// ĐIỀU CHỈNH: Đưa dòng này lên TRƯỚC builder.Build()
builder.Services.AddDbContext<FootballFieldDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// --- PHẦN 2: XÂY DỰNG APP ---

var app = builder.Build();

// --- PHẦN 3: CẤU HÌNH PIPELINE (MIDDLEWARE) ---

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();