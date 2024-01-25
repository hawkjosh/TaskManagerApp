namespace TaskManagerApp
{
    public class Task
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }

        public Task(string name, DateTime dueDate)
        {
            Name = name;
            DueDate = dueDate;
        }
    }
}