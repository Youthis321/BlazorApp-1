public class TodoItem
{
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
    public string Category { get; set; } = "Pribadi";
    public DateTime? Deadline { get; set; }
}