namespace ToDoApp
{
    public class AppController
    {
        public void Run()
        {
            while (true)
            {
                ShowMainMenu();
            }
        }

        public void ShowMainMenu()
        {
            int choice;

            Console.Clear();
            Console.WriteLine("Task Manager App");
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Edit Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Select an option:  ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ActionItem("View Tasks");
                        break;
                    case 2:
                        ActionItem("Add Task");
                        break;
                    case 3:
                        ActionItem("Edit Task");
                        break;
                    case 4:
                        ActionItem("Delete Task");
                        break;
                    case 5:
                        ShowExitMessage();
                        break;
                    default:
                        ShowErrorMessage("Invalid option. Press any key to continue . . . ");
                        break;
                }
            }
            else
            {
                ShowErrorMessage("Invalid option. Press any key to continue . . . ");
            }
        }

        public void ShowAltMenu()
        {
            int choice;
            bool showAltMenu = true;

            while (showAltMenu)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("< View Tasks (1) | Add Task (2) | Edit Task (3) | Delete Task (4) | Main Menu (5) | Exit (6) >  ");
                Console.ResetColor();
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ActionItem("View Tasks");
                            break;
                        case 2:
                            ActionItem("Add Task");
                            break;
                        case 3:
                            ActionItem("Edit Task");
                            break;
                        case 4:
                            ActionItem("Delete Task");
                            break;
                        case 5:
                            showAltMenu = false;
                            ShowMainMenu();
                            break;
                        case 6:
                            ShowExitMessage();
                            break;
                        default:
                            ShowErrorMessage("Invalid option. Press any key to continue . . . ");
                            break;
                    }
                }
                else
                {
                    ShowErrorMessage("Invalid option. Press any key to continue . . . ");
                }
            }
        }

        public void ActionItem(string title)
        {
            string actionItemMessage = "Press any key to simulate action item . . . ";
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine(new string('-', title.Length));
            Console.WriteLine();
            Console.Write(actionItemMessage);
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', actionItemMessage.Length + 1));
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(actionItemMessage);
            Console.WriteLine();
            Console.WriteLine();
            ShowAltMenu();
        }

        public void ShowErrorMessage(string message)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ResetColor();
            Console.ReadKey();
        }

        public void ShowExitMessage()
        {
            string errorMessage = "| Thanks for using ToDo App!! Press any key to exit . . . |";
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', errorMessage.Length));
            Console.WriteLine("|" + new string(' ', errorMessage.Length - 2) + "|");
            Console.WriteLine("| Thanks for using ToDo App!! Press any key to exit . . . |");
            Console.WriteLine("|" + new string(' ', errorMessage.Length - 2) + "|");
            Console.WriteLine(new string('-', errorMessage.Length));
            Console.ResetColor();
            Console.ReadKey();
            Console.CursorVisible = true;
            Environment.Exit(0);
        }

        //public List<Task> TasksList = new List<Task>();

        //public void Run()
        //{
        //    while (true)
        //    {
        //        ShowMainMenu();
        //    }
        //}

        //public class Task
        //{
        //    public string Name { get; set; }
        //    public DateTime DueDate { get; set; }

        //    public Task(string name, DateTime dueDate)
        //    {
        //        Name = name;
        //        DueDate = dueDate;
        //    }
        //}

        //public Task GetTaskByIndex(int taskIndex) => TasksList[taskIndex + 1];

        //public void ShowMainMenu()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Task Manager App");
        //    Console.WriteLine("----------------");
        //    Console.WriteLine();
        //    Console.WriteLine("1. View Tasks");
        //    Console.WriteLine("2. Add Task");
        //    Console.WriteLine("3. Edit Task");
        //    Console.WriteLine("4. Delete Task");
        //    Console.WriteLine("5. Exit");
        //    Console.WriteLine();
        //    Console.Write("Select an option: ");
        //    int choice = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        //    switch (choice)
        //    {
        //        case 1:
        //            ViewTasks();
        //            break;
        //        case 2:
        //            AddTask();
        //            break;
        //        case 3:
        //            EditTask();
        //            break;
        //        case 4:
        //            DeleteTask();
        //            break;
        //        case 5:
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Invalid option. Press any key to continue . . .");
        //            Console.ResetColor();
        //            Console.Read();
        //            ShowMainMenu();
        //            break;
        //    }
        //}

        //public void ShowNoTasksMenu()
        //{
        //    Console.WriteLine();
        //    Console.ForegroundColor = ConsoleColor.DarkYellow;
        //    Console.Write("< Add Task (1) | Main Menu (2) | Exit (3) >  ");
        //    Console.ResetColor();
        //    int choice = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        //    switch (choice)
        //    {
        //        case 1:
        //            AddTask();
        //            break;
        //        case 2:
        //            ShowMainMenu();
        //            break;
        //        case 3:
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Invalid option. Press any key to continue . . .");
        //            Console.ResetColor();
        //            Console.Read();
        //            Console.SetCursorPosition(0, Console.CursorTop - 2);
        //            Console.Write(new string(' ', Console.WindowWidth));
        //            Console.SetCursorPosition(0, Console.CursorTop - 1);
        //            ShowNoTasksMenu();
        //            break;
        //    }
        //}

        //public void ShowAltMenu()
        //{
        //    Console.WriteLine();
        //    Console.ForegroundColor = ConsoleColor.DarkYellow;
        //    Console.Write("< Add Task (1) | Edit Task (2) | Delete Task (3) | Main Menu (4) | Exit (5) >  ");
        //    Console.ResetColor();
        //    int choice = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        //    switch (choice)
        //    {
        //        case 1:
        //            AddTask();
        //            break;
        //        case 2:
        //            EditTask();
        //            break;
        //        case 3:
        //            DeleteTask();
        //            break;
        //        case 4:
        //            ShowMainMenu();
        //            break;
        //        case 5:
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Invalid option. Press any key to continue . . .");
        //            Console.ResetColor();
        //            Console.Read();
        //            Console.SetCursorPosition(0, Console.CursorTop - 2);
        //            Console.Write(new string(' ', Console.WindowWidth));
        //            Console.SetCursorPosition(0, Console.CursorTop - 1);
        //            ShowAltMenu();
        //            break;
        //    }
        //}

        //public void ShowInvalidMenu()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("Task not found. Press any key to continue . . .");
        //    Console.ResetColor();
        //    Console.Read();
        //    Console.SetCursorPosition(0, Console.CursorTop - 2);
        //    Console.Write(new string(' ', Console.WindowWidth));
        //    Console.SetCursorPosition(0, Console.CursorTop - 1);
        //    ShowAltMenu();
        //}

        //public void ViewTasks()
        //{
        //    Console.Clear();
        //    if (TasksList.Count == 0)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("You have not created any tasks.");
        //        Console.ResetColor();
        //        ShowNoTasksMenu();
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        Console.WriteLine("My Tasks:");
        //        Console.WriteLine("--------");
        //        Console.ResetColor();
        //        Console.WriteLine();
        //        foreach (Task task in TasksList)
        //        {
        //            Console.WriteLine($"{TasksList.IndexOf(task) + 1}. {task.Name} - {task.DueDate}");
        //        }
        //    }
        //    ShowAltMenu();
        //}

        //public void AddTask()
        //{
        //    string taskName;
        //    DateTime taskDueDate;
        //    Console.Clear();
        //    Console.Write("Enter task name: ");
        //    taskName = Console.ReadLine();
        //    Console.Write("Enter due date: ");
        //    taskDueDate = DateTime.Parse(Console.ReadLine());
        //    Task task = new Task(taskName, taskDueDate);
        //    TasksList.Add(task);
        //    Console.WriteLine();
        //    Console.WriteLine("Task added successfully.");
        //    ShowAltMenu();
        //}

        //public void EditTask()
        //{
        //    string newTaskName;
        //    DateTime newDueDate;
        //    Console.Write("Enter task number to edit: ");
        //    int taskIndex = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        //    Task task = GetTaskByIndex(taskIndex);
        //    if (task != null)
        //    {
        //        Console.Write("Enter new task name: ");
        //        newTaskName = Console.ReadLine();
        //        Console.Write("Enter new due date: ");
        //        newDueDate = DateTime.Parse(Console.ReadLine());
        //        task.Name = newTaskName;
        //        task.DueDate = newDueDate;
        //        Console.WriteLine();
        //        Console.WriteLine("Task updated successfully.");
        //        ShowAltMenu();
        //    }
        //    else
        //    {
        //        ShowInvalidMenu();
        //    }
        //}

        //public void DeleteTask()
        //{
        //    Console.Write("Enter task number to remove: ");
        //    int taskIndex = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        //    Task task = GetTaskByIndex(taskIndex);
        //    if (task != null)
        //    {
        //        TasksList.Remove(task);
        //        Console.WriteLine("Task deleted successfully.");
        //        ShowAltMenu();
        //    }
        //    else
        //    {
        //        ShowInvalidMenu();
        //    }
        //}
    }
}
