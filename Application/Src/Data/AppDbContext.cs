using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Source.Models;

namespace Source.Data;

public class AppDbContext : IdentityDbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

  DbSet<Leed> Leeds { get; set; }
}


