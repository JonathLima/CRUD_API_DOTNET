
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Domain.Dto
{
  public class TaskListDto
  {

    public Guid Id { get; set; }

    public String? Name { get; set; }

    public String? Description { get; set; }

    public Boolean isChecked { get; set; }

    public DateTime Created_At { get; set; }

  }
}