using Microsoft.EntityFrameworkCore;
using TaskManagementApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddDbContext<TaskContext>(opt =>
    opt.UseInMemoryDatabase("TaskList"));
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
