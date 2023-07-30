namespace TodoAppWebAPP.Models;

public class Todo
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string RequestId { get; internal set; }
}

