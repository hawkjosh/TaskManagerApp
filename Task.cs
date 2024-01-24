namespace TaskManagerApp
{
    internal class Task
    {
        public string Name { get; }
        public DateTime DueDate { get; }

        public Task(string name, DateTime dueDate)
        {
            Name = name;
            DueDate = dueDate;
        }
    }
}
