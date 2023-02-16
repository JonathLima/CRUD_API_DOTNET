
using Models;
using Newtonsoft.Json;

namespace Domain.Dto
{
  public class TaskListDto
  {
    [JsonProperty("id")]
    public Guid Id { get; set; }

    [JsonProperty("name")]
    public String? Name { get; set; }

    [JsonProperty("description")]
    public String? Description { get; set; }

    [JsonProperty("ischecked")]
    public Boolean IsChecked { get; set; }

    [JsonProperty("created_At")]
    public DateTime Created_At { get; set; }

    public void MapModel(TaskList model)
    {
      Id = model.Id;
      Name = model.Name;
      Description = model.Description;
      IsChecked = model.IsChecked;
      Created_At = model.Created_At;
    }

  }
}