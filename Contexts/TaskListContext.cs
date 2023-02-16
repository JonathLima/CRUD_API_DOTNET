using Microsoft.EntityFrameworkCore;
using Models;

namespace Contexts
{
  public class TaskListContext : DbContext
  {
    public TaskListContext(DbContextOptions<TaskListContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    public DbSet<TaskList> TaskLists { get; set; }
  }
}