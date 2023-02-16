using Domain.Dto;
using Models;

namespace Domain.Interfaces.Services
{
  public interface ITaskListService
  {
    Task<TaskList> GetTaskServiceAsync(string Id);
    Task<IEnumerable<TaskList>?> GetAllTasksServiceAsync();
    Task<TaskList> CreateTaskServiceAsync(TaskListDto DataTask);
    Task<TaskList> UpdateTaskByIdServiceAsync(TaskListDto DataTaskList, string Id);
    Task<TaskList> DeleteTaskByIdServiceAsync(string Id);
  }
}