using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contexts;
using Domain.Dto;
using Interfaces;
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
      throw new NotImplementedException();
    }

    public async Task<TaskList> DeleteTaskByIdRepositoryAsync(string Id)
    {
      throw new NotImplementedException();
    }

    public async Task<IEnumerable<TaskList>?> GetAllTasksRepositoryAsync()
    {
      throw new NotImplementedException();
    }

    public async Task<TaskList> GetTaskRepositoryAsync(string Id)
    {
      throw new NotImplementedException();
    }

    public async Task<TaskList> UpdateTaskByIdRepositoryAsync(TaskListDto DataTaskList, string Id)
    {
      throw new NotImplementedException();
    }
  }
}