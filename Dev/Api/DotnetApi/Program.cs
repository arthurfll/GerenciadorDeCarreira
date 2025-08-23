using DotnetApi.Data;
using Microsoft.EntityFrameworkCore;
using DotnetApi.Services;
using DotnetApi.Repositories;
using Prometheus;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
  options =>
    options.UseNpgsql(
      builder.Configuration.GetConnectionString("DefaultConnection")
  )
);
builder.Services.AddControllers();
builder.Services.AddScoped<TarefaService>();
builder.Services.AddScoped<TarefaRepository>();

var app = builder.Build();

app.UseHttpMetrics();
app.MapMetrics();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();



