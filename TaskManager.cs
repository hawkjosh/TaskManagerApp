namespace TaskManagerApp
{
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public Task GetTaskByName(string taskName) => tasks.FirstOrDefault(task => task.Name == taskName);

        public void RemoveTask(string taskName) => tasks.RemoveAll(task => task.Name == taskName);

        public void ListTasks()
        {
            foreach (var task in tasks)
            {
                string formattedDueDate = task.DueDate.ToString("ddd, M/d/yy");
                Console.WriteLine("");
                Console.WriteLine($"- {task.Name} (Due: {formattedDueDate})");
            }
        }
    }
}
