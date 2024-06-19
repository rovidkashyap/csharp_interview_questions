using System;

namespace garbage_collection
{
    // 1. Garbage Collection (GC) in C# is an automatic memory management feature provided by the .NET runtime environment.
    // 2. Its primary purpose is to free up memory occupied by objects that are no longer in use by the application, thus preventing memory leaks and optimizing the application's performance.
    // 3. The garbage collector automatically manages the allocation and release of memory for your application.
    // 4. Garbage Collection organised objects into three generations:
    // 5. Generation 0 - Contains Short-lived objects. These are collected frequently.
    // 6. Generation 1 - Serves as buffer between short-lives and long-lived objects.
    // 7. Generation 2 - Contains long-lived objects. These are collected less frequently

    public class Program
    {
        static void Main(string[] args)
        {
            // Create large object
            MyClass myObject = new MyClass();

            // Use the Object
            myObject.DoSomething();

            // Set the reference to null, making the object eligible for garbage collection
            myObject = null;

            // FOrce garbage collection (not recommended for production code)
            GC.Collect();

            Console.WriteLine("Garbage Collection has been forced.");
        }
    }

    class MyClass
    {
        ~MyClass()
        {
            Console.WriteLine("Destructor called. Object is being collected.");
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }
    }

    // SUMMARY

    // Garbage Collection: Automatic memory management feature in .NET that frees memory occupied by objects that are no longer in use.
    // Generations: Organizes objects into Generation 0, 1, and 2 to optimize collection frequency and performance.
    // Process: Involves marking reachable objects, sweeping unreferenced objects, and compacting memory.
    // Best Practices: Avoid forcing GC, implement IDisposable for unmanaged resources, minimize unnecessary allocations, and monitor performance.
}
