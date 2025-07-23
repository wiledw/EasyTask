using TaskApi.Data;
using TaskApi.Services;
using TaskApi.Middleware;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// DbContext (reads connection string from configuration)
builder.Services.AddDbContext<TaskDbContext>(opt =>
    opt.UseMySql(
      builder.Configuration.GetConnectionString("Default"),
      ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("Default"))
    )
);

// DI for our service
builder.Services.AddScoped<ITaskService, TaskService>();

builder.Services.AddControllers();
builder.Services.AddCors(opt =>
    opt.AddDefaultPolicy(p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader())
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseCors();
app.MapControllers();
app.Run();
