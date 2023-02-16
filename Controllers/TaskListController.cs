using System.Net;
using Domain.Dto;
using Domain.Interfaces.Services;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
  [ApiController]

  [Route("v1/[controller]")]
  public class TaskListController : ControllerBase
  {
    private readonly ITaskListService _taskService;
    TaskListController(ITaskListService taskService) => _taskService = taskService;


    [HttpGet("GetAllTasks")]
    public async Task<IActionResult> GetAllTasksAsync()
    {
      var data = await _taskService.GetAllTasksServiceAsync();

      if (data == null)
      {
        return NotFound();
      }
      return Ok();
    }

    [HttpGet("GetTaskById")]
    public async Task<IActionResult> GetTaskAsync([FromHeader] string Id)
    {
      var data = await _taskService.GetTaskServiceAsync(Id);

      if (data == null)
      {
        return NotFound();
      }
      return Ok();
    }

    [HttpPost("CreateTask")]
    public async Task<IActionResult> CreateTaskAsync([FromBody] TaskListDto CreateTaskList)
    {
      var data = await _taskService.CreateTaskServiceAsync(CreateTaskList);

      if (data == null)
      {
        return NotFound();
      }
      return Ok();
    }

    [HttpPut("UpdateTaskById")]
    public async Task<IActionResult> UpdateTaskByIdAsync([FromBody] TaskListDto CreateTaskList, [FromHeader] string Id)
    {
      var data = await _taskService.UpdateTaskByIdServiceAsync(CreateTaskList, Id);

      if (data == null)
      {
        return NotFound();
      }
      return Ok();
    }

    [HttpDelete("DeleteTaskbyId")]
    public async Task<IActionResult> DeleteTaskbyIdAsync([FromHeader] string Id)
    {
      var data = await _taskService.DeleteTaskByIdServiceAsync(Id);

      if (data == null)
      {
        return NotFound();
      }
      return Ok();
    }

  }
}