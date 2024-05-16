class Task
{
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public TaskStatus Status { get; set; }

    public Task(string description, DateTime dueDate, TaskStatus status)
    {
        Description = description;
        DueDate = dueDate;
        Status = status;
    }

    public override string ToString()
    {
        return $"- {Description} (Due: {DueDate.ToShortDateString()}, Status: {Status})";
    }
}
