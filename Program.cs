namespace TaskManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            while (true)
            {
                Console.WriteLine("Task Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. List Tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter task name: ");
                        string taskName = Console.ReadLine();
                        Console.Write("Enter due date: ");
                        DateTime dueDate = DateTime.Parse(Console.ReadLine());

                        taskManager.AddTask(new Task(taskName, dueDate));
                        break;
                    case 2:
                        Console.Write("Enter task name to remove: ");
                        string taskToRemove = Console.ReadLine();

                        taskManager.RemoveTask(taskToRemove);
                        break;
                    case 3:
                        Console.WriteLine("Task List:");
                        taskManager.ListTasks();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
