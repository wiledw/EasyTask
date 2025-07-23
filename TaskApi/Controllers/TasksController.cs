using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using TaskApi.Services;

namespace TaskApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TasksController : ControllerBase
  {
    private readonly ITaskService _svc;
    public TasksController(ITaskService svc) => _svc = svc;

    [HttpGet]
    public async Task<IActionResult> Get() =>
        Ok(await _svc.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> Post(TaskItem item)
    {
      var created = await _svc.CreateAsync(item);
      return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }

    [HttpPut("{id}/toggle")]
    public async Task<IActionResult> Toggle(int id)
    {
      if (await _svc.ToggleCompleteAsync(id))
        return NoContent();
      return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      if (await _svc.DeleteAsync(id))
        return NoContent();
      return NotFound();
    }
  }
}
