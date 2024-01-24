namespace TaskManagerApp
{
    internal class TaskManager
    {
        private List<Task> tasks = new List<Task>();

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(string taskName)
        {
            tasks.RemoveAll(task => task.Name == taskName);
        }

        public void ListTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Name} (Due: {task.DueDate})");
            }
        }
    }
}
