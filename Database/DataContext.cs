using Microsoft.EntityFrameworkCore;
using ASPNET_Boilerplate.Models;

namespace ASPNET_Boilerplate.Database;

public class DataContext : DbContext {
  public DataContext(DbContextOptions<DataContext> options) : base(options) {

  }

  public DbSet<User> Users => Set<User>();
}
