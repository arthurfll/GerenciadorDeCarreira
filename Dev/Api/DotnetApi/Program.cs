using DotnetApi.Data;
using Microsoft.EntityFrameworkCore;
using DotnetApi.Services;
using DotnetApi.Repositories;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
  options => 
    options.UseNpgsql(
      builder.Configuration.GetConnectionString("DefaultConnection")
  )
);

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();



