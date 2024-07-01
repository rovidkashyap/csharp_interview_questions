using System;
using System.Threading;
using System.Threading.Tasks;

namespace task_vs_thread_in_csharp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // In C#, both `Task` and `Thread` are used for asynchronous and parallel programming, but
            // they serve different purposes and are use in different contexts.

            // `Task` -

            // 1. When you want to perform asynchronous operations or parallel tasks without needing
            //     direct control over threads.

            // 2. When you want to take advantage of the Task Parallel Library's features such as 
            //    continuations, cancellation, and exception handling.

            // 3. When you want to write more maintainable and higher-level asynchronous code, especially
            //    with the `async` and `await` keywords.

            #region Task Example
            await Task.Run(() => DoWork());
            Console.WriteLine("Task Work completed");
            #endregion

            // `Thread` -

            // 1. When you need fine-grained control over the thread's lifecycle and behavior.

            // 2. When you need to perform a long-running operation that requires explicit thread management

            // 3. When working with legacy code that is based on `Thread`.

            #region Thread Example
            Thread thread = new Thread(new ThreadStart(DoThreadWork));
            thread.Start();
            thread.Join();      // Wait for the thread to complete
            Console.WriteLine("Thread Work completed");
            #endregion
        }

        static void DoWork()
        {
            // Simulate work
            Task.Delay(1000).Wait();
            Console.WriteLine("Doing Task work...");
        }

        static void DoThreadWork()
        {
            // Simulate work
            Thread.Sleep(1000);
            Console.WriteLine("\nDoing Thread work...");
        }
    }
}
