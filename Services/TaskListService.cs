
using Domain.Dto;
using Domain.Interfaces.Services;
using Interfaces;
using Models;

namespace Services
{
  public class TaskListService : ITaskListService
  {
    private readonly ITaskListRepository _taskRepository;
    TaskListService(ITaskListRepository taskRepository)
    {
      _taskRepository = taskRepository;
    }

    public async Task<TaskList> CreateTaskServiceAsync(TaskListDto DataTaskList)
    {
      throw new NotImplementedException();
    }

    public async Task<TaskList> DeleteTaskByIdServiceAsync(string Id)
    {
      throw new NotImplementedException();
    }

    public async Task<IEnumerable<TaskList>?> GetAllTasksServiceAsync()
    {
      throw new NotImplementedException();
    }

    public async Task<TaskList> GetTaskServiceAsync(string Id)
    {
      throw new NotImplementedException();
    }

    public async Task<TaskList> UpdateTaskByIdServiceAsync(TaskListDto DataTaskList, string Id)
    {
      throw new NotImplementedException();
    }
  }
}