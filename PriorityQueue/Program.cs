using System;
using System.Collections.Generic;

// Task class representing a process or thread
public class Task
{
    public string Name { get; set; }
    public int Priority { get; set; }

    public Task(string name, int priority)
    {
        Name = name;
        Priority = priority;
    }
}

// TaskScheduler class representing the task scheduler
public class TaskScheduler
{
    private PriorityQueue<Task> priorityQueue;

    public TaskScheduler()
    {
        // Initialize the priority queue
        priorityQueue = new PriorityQueue<Task>();
    }

    // Enqueue a task with its priority
    public void EnqueueTask(Task task)
    {
        priorityQueue.Enqueue(task, task.Priority);
    }

    // Dequeue the next task with the highest priority
    public Task DequeueTask()
    {
        return priorityQueue.Dequeue();
    }

    // Check if the task scheduler is empty
    public bool IsEmpty()
    {
        return priorityQueue.Count == 0;
    }
}

// Priority queue implementation
public class PriorityQueue<T>
{
    private SortedDictionary<int, Queue<T>> queueDict;

    public int Count { get; private set; }

    public PriorityQueue()
    {
        queueDict = new SortedDictionary<int, Queue<T>>();
        Count = 0;
    }

    public void Enqueue(T item, int priority)
    {
        if (!queueDict.ContainsKey(priority))
        {
            queueDict[priority] = new Queue<T>();
        }
        queueDict[priority].Enqueue(item);
        Count++;
    }

    public T Dequeue()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        foreach (var priority in queueDict.Keys)
        {
            if (queueDict[priority].Count > 0)
            {
                Count--;
                return queueDict[priority].Dequeue();
            }
        }
        return default(T); // This should not happen if Count is being correctly updated
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a task scheduler
        TaskScheduler taskScheduler = new TaskScheduler();

        // Enqueue some tasks with their priorities
        taskScheduler.EnqueueTask(new Task("Task1", 3));
        taskScheduler.EnqueueTask(new Task("Task2", 1));
        taskScheduler.EnqueueTask(new Task("Task3", 2));

        // Dequeue and execute tasks in priority order
        while (!taskScheduler.IsEmpty())
        {
            Task task = taskScheduler.DequeueTask();
            Console.WriteLine($"Executing {task.Name} (Priority: {task.Priority})");
            // Simulate task execution
        }
    }
}
