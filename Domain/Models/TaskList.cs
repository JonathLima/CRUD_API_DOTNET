using Domain.Dto;

namespace Models
{
  public class TaskList
  {
    public Guid Id { get; set; }

    public String? Name { get; set; }

    public String? Description { get; set; }

    public Boolean IsChecked { get; set; }

    public DateTime Created_At { get; set; }

    public void MapDto(TaskListDto dto)
    {
      Id = dto.Id;
      Name = dto.Name;
      Description = dto.Description;
      IsChecked = dto.IsChecked;
      Created_At = dto.Created_At;
    }

  }
}