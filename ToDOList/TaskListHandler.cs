using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ToDoList;

public class TaskListHandler
{
    private static string filePath = "C:\\Users\\user\\RiderProjects\\ToDOList\\ToDOList\\myTasks.json";
    public static Dictionary<int,string> task = new Dictionary<int,string>();

    public static void AddTask(int taskNumber, string taskToAdd)
    {
        if (!task.ContainsKey(taskNumber))
        {
            task.Add(taskNumber, taskToAdd);
        }
        else
        {
            Console.WriteLine($"Task №{taskNumber} already exists");
        }
        
    }
    public static void SaveTasks(){
        
        string jsonData = JsonSerializer.Serialize(task);
        File.WriteAllText(filePath, jsonData);
        Console.WriteLine("Your task saved to JSON file.");
    }

    public static void ShowTasks()
    {
        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            task = JsonSerializer.Deserialize<Dictionary<int, string>>(jsonData) ?? new Dictionary<int, string>();
            Console.WriteLine("Tasks have been loaded from the JSON file.");
            Console.WriteLine("Your tasks:");
            foreach (var t in task)
            {
                Console.WriteLine($"Task {t.Key}: {t.Value}");
            }
        }
        else
        {
            Console.WriteLine("No task file found, starting with an empty task list.");
        }
    }

    public static void DeleteAllTasks()
    {
        task.Clear();
        SaveTasks();
    }
    
    
}