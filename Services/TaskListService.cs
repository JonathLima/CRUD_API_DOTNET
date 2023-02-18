
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
      var entityData = await _taskRepository.CreateTaskRepositoryAsync(DataTaskList);

      if (entityData == null)
      {
        throw new ArgumentException("Task não encontrada.");
      }

      return entityData;

    }

    public async Task<TaskList> DeleteTaskByIdServiceAsync(string Id)
    {
      var entityData = await _taskRepository.DeleteTaskByIdRepositoryAsync(Id);

      return entityData;
    }

    public async Task<IEnumerable<TaskList>?> GetAllTasksServiceAsync()
    {
      var entityData = await _taskRepository.GetAllTasksRepositoryAsync();

      return entityData;
    }

    public async Task<TaskList> GetTaskServiceAsync(string Id)
    {
      var entityData = await _taskRepository.GetTaskRepositoryAsync(Id);

      return entityData;
    }

    public async Task<TaskList> UpdateTaskByIdServiceAsync(TaskListDto DataTaskList, string Id)
    {
      TaskList updateDataEntity = new TaskList();
      var entityData = await _taskRepository.UpdateTaskByIdRepositoryAsync(DataTaskList, Id);
      return updateDataEntity;
    }
  }
}