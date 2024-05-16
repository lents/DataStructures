// Create a queue to represent the print job queue
Queue<PrintJob> printQueue = new Queue<PrintJob>();

// Add print jobs to the queue
printQueue.Enqueue(new PrintJob("Document1.pdf"));
printQueue.Enqueue(new PrintJob("Document2.pdf"));
printQueue.Enqueue(new PrintJob("Document3.pdf"));

// Process print jobs in FIFO order
while (printQueue.Count > 0)
{
    PrintJob currentJob = printQueue.Dequeue();
    Console.WriteLine("Printing: " + currentJob.DocumentName);
    // Simulate printing process...
    Console.WriteLine("Printed: " + currentJob.DocumentName);
}
    

class PrintJob
{
    public string DocumentName { get; }

    public PrintJob(string documentName)
    {
        DocumentName = documentName;
    }
}