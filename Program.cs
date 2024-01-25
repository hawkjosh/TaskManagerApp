using System;

namespace TaskManagerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            while (true)
            {
                Console.WriteLine("Task Manager");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Edit Task");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("My Tasks:");
                        Console.WriteLine("----------");
                        taskManager.ListTasks();
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.Write("Enter task name: ");
                        string taskName = Console.ReadLine();
                        Console.Write("Enter due date: ");
                        DateTime dueDate = DateTime.Parse(Console.ReadLine());
                        taskManager.AddTask(new Task(taskName, dueDate));
                        break;
                    case 3:
                        Console.Write("Enter task name to edit: ");
                        string taskToEdit = Console.ReadLine();
                        Task task = taskManager.GetTaskByName(taskToEdit);
                        if (task != null)
                        {
                            Console.Write("Enter new task name: ");
                            string newTaskName = Console.ReadLine();
                            Console.Write("Enter new due date: ");
                            DateTime newDueDate = DateTime.Parse(Console.ReadLine());
                            task.Name = newTaskName;
                            task.DueDate = newDueDate;
                            Console.WriteLine("Task edited successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Task not found.");
                        }
                        break;
                    case 4:
                        Console.Write("Enter task name to delete: ");
                        string taskToRemove = Console.ReadLine();
                        taskManager.RemoveTask(taskToRemove);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Try again.");
                        break;
                }
            }
        }
    }
}