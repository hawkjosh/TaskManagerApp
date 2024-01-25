using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace TaskManager
{
    public class TaskData
    {
        public List<Task> Tasks { get; set; }

        public TaskData()
        {
            Tasks = new List<Task>();
        }

        string fileName = Path.Combine(Directory.GetCurrentDirectory(), "data.json");

        public void SaveTasksToJson(string fileName, TaskData taskData)
        {
            string json = JsonSerializer.Serialize(taskData);
            File.WriteAllText(fileName, json);
        }

        public TaskData LoadTasksFromJson(string fileName)
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<TaskData>(json);
            }
            else
            {
                return new TaskData();
            }
        }
    }
}
