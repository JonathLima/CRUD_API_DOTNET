using Domain.Dto;
using Models;

namespace Interfaces
{
  public interface ITaskListRepository
  {

    Task<TaskList> GetTaskRepositoryAsync(string Id);
    Task<IEnumerable<TaskList>?> GetAllTasksRepositoryAsync();
    Task<TaskList> CreateTaskRepositoryAsync(TaskListDto DataTaskList);
    Task<TaskList> UpdateTaskByIdRepositoryAsync(TaskListDto DataTaskList, string Id);
    Task<TaskList> DeleteTaskByIdRepositoryAsync(string Id);
  }

}