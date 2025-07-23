using Microsoft.EntityFrameworkCore;
using TaskApi.Models;

namespace TaskApi.Data
{
  public class TaskDbContext : DbContext
  {
    public TaskDbContext(DbContextOptions<TaskDbContext> opts)
        : base(opts) { }

    public DbSet<TaskItem> Tasks => Set<TaskItem>();
  }
}
