using Microsoft.EntityFrameworkCore;
using RolService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add PostgreSQL connection
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();
