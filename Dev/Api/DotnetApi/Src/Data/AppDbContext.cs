using Microsoft.EntityFrameworkCore;
using DotnetApi.Models;


namespace DotnetApi.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }
  DbSet<Tarefa> Tarefas { get; set; }
}



