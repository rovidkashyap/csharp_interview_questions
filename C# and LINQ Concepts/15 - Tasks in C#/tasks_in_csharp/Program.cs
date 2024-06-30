using System;
using System.Threading.Tasks;

namespace tasks_in_csharp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // In C#, a Task represents an asynchronous operation or unit of work that can be
            // executed concurrently with other tasks or the main application thread. Task is
            // part of the Task Parallel Library (TPL) in .NET, providing a higher-level
            // abstraction over threads for asynchronous programming.

            // Create and start a task
            Task<int> task = Task.Run(() =>
            {
                // Simulate some work
                Task.Delay(2000).Wait();    // or await Task.Delay(2000)
                return 42;
            });

            // Do other work in the main thread while waiting for the task
            Console.WriteLine("Main thread doing other work...");

            // Await the task to retrieve the result asynchronously
            int result = await task;
            Console.WriteLine($"Task result: {result}");

            // Task Methods and Properties:

            // `Task.Run()` - Starts a new task and run a delegate asynchronously on a thread pool thread.
            // `Task.Delay()` - Delays the execution of the task without blocking the thread.
            // `Task.Wait()` - Blocks the current thread until task completes.
            // `Task.Result` - Retrieve the result of a task synchronously (not recommended with async method).
            // `Task.ContinueWith()` - Attaches a continuuation task that runs after the first task completes.
        }
    }
}
