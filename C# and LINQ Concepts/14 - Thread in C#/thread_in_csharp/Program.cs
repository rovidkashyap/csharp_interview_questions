using System;
using System.Threading;

namespace thread_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, a thread represent flow of execution within a process. Threads allow your program
            // to execute multiple tasks concerrently, making efficient use of available processor cores
            // and enabling responsive applications.

            // 1. Create a Thread

            // Create a new thread and specify the method to execute
            Thread thread = new Thread(WorkerMethod);

            // Start the thread
            thread.Start();

            // Main thread continues its own execution
            Console.WriteLine("Main thread continues....");
        }

        static void WorkerMethod()
        {
            Console.WriteLine("Worker thread started.");
            // Thread's work goes here
            Console.WriteLine("Worker thread finished.");
        }
    }
}
