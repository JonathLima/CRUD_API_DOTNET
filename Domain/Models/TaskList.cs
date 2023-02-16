namespace Models
{
  public class TaskList
  {
    public Guid Id { get; set; }

    public String? Name { get; set; }

    public String? Description { get; set; }

    public Boolean isChecked { get; set; }

    public DateTime Created_At { get; set; }

  }
}