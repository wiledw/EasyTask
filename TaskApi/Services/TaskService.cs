using Microsoft.EntityFrameworkCore;
using TaskApi.Data;
using TaskApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskApi.Services
{
  public class TaskService : ITaskService
  {
    private readonly TaskDbContext _db;
    public TaskService(TaskDbContext db) => _db = db;

    public async Task<IEnumerable<TaskItem>> GetAllAsync() =>
        await _db.Tasks.AsNoTracking()
                       .OrderBy(t => t.CreatedAt)
                       .ToListAsync();

    public async Task<TaskItem> CreateAsync(TaskItem item)
    {
      _db.Tasks.Add(item);
      await _db.SaveChangesAsync();
      return item;
    }

    public async Task<bool> ToggleCompleteAsync(int id)
    {
      var t = await _db.Tasks.FindAsync(id);
      if (t == null) return false;
      t.IsComplete = !t.IsComplete;
      await _db.SaveChangesAsync();
      return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var t = await _db.Tasks.FindAsync(id);
      if (t == null) return false;

      _db.Tasks.Remove(t);
      await _db.SaveChangesAsync();
      return true;
    }
  }
}
