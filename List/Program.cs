using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store tasks
        List<Task> tasks = new List<Task>();

        // Add some initial tasks
        tasks.Add(new Task("Finish report", new DateTime(2024, 5, 15), TaskStatus.Pending));
        tasks.Add(new Task("Buy groceries", new DateTime(2024, 5, 20), TaskStatus.Pending));
        tasks.Add(new Task("Call mom", new DateTime(2024, 5, 17), TaskStatus.Pending));

        // Display the tasks
        Console.WriteLine("Tasks:");
        foreach (Task task in tasks)
        {
            Console.WriteLine(task);
        }

        // Update a task status
        tasks[0].Status = TaskStatus.Completed;

        // Remove a task
        tasks.RemoveAt(1);

        // Display the updated list of tasks
        Console.WriteLine("\nUpdated Tasks:");
        foreach (Task task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}
