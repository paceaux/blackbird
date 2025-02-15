using System;

namespace Blackbird;

public class TodoItem
{
    public string? Title {get; set;}
    public bool IsDone { get; set; }
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }
}
