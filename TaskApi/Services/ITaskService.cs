using TaskApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskApi.Services
{
  public interface ITaskService
  {
    Task<IEnumerable<TaskItem>> GetAllAsync();
    Task<TaskItem> CreateAsync(TaskItem item);
    Task<bool> ToggleCompleteAsync(int id);
    Task<bool> DeleteAsync(int id);
  }
}
