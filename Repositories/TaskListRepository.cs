using Contexts;
using Domain.Dto;
using Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
  public class TaskListRepository : ITaskListRepository
  {
    private readonly TaskListContext _taskListDbContext;
    TaskListRepository(TaskListContext TaskListDbContext)
    {
      _taskListDbContext = TaskListDbContext;
    }
    public async Task<TaskList> CreateTaskRepositoryAsync(TaskListDto DataTaskList)
    {

      TaskList dataEntity = new TaskList();
      dataEntity.MapDto(DataTaskList);

      if (dataEntity.Id == DataTaskList.Id)
      {
        throw new ArgumentException("Task já existe.");
      }

      await _taskListDbContext.TaskLists.AddAsync(dataEntity);
      await _taskListDbContext.SaveChangesAsync();

      return dataEntity;

    }

    public async Task<TaskList> DeleteTaskByIdRepositoryAsync(string Id)
    {
      var taskId = await _taskListDbContext.TaskLists.FindAsync(Id);


      if (taskId == null)
      {
        throw new ArgumentException("Task não encontrada ou não existe.");
      }

      return taskId;
    }

    public async Task<IEnumerable<TaskList>?> GetAllTasksRepositoryAsync()
    {
      return await _taskListDbContext.TaskLists.ToListAsync();
    }

    public async Task<TaskList> GetTaskRepositoryAsync(string Id)
    {

      var taskId = await _taskListDbContext.TaskLists.FindAsync(Id);
      if (taskId == null)
      {
        throw new ArgumentException("aaa");
      }

      return taskId;

    }

    public async Task<TaskList> UpdateTaskByIdRepositoryAsync(TaskListDto DataTaskList, string Id)
    {
      TaskList dataEntity = new TaskList();
      dataEntity.MapDto(DataTaskList);

      var database = await _taskListDbContext.TaskLists.FindAsync(Id);


      if (database == null)
      {
        throw new ArgumentException("Task não encontrada.");
      }

      if (dataEntity.Id.ToString() == Id)
      {
        _taskListDbContext.TaskLists.Update(dataEntity);

      }


      return dataEntity;

    }
  }
}