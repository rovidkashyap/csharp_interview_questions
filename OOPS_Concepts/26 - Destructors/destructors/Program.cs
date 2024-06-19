using System;

namespace destructors
{
    // 1. In C#, a destructor is a special method in a class that is invoked automatically when an object is destroyed or finalized by the garbage collector.
    // 2. Destructors are used to clean up any resources that the object may be holding, such as file handles, network connections, or unmanaged resources
    // that are not managed by the garbage collector.
    // 3. A destructor is defined using a tilde (~) followed by the class name.
    // 4. Destructors cannot have access modifiers.
    // 5. A class can have only one destructor.
    // 6. Destructors cannot have parameters and cannot be called explicitly.
    // 7. Destructors cannot be inherited or overloaded
    // 8. The garbage collector automatically calls the destructor, so you don't need to (and cannot) invoke it directly.

    class ResourceHolder
    {
        // Constructor
        public ResourceHolder()
        {
            Console.WriteLine("ResouceHolder created.");
            // Allocate all resource here (e.g. open a file, allocate memory, etc)
        }

        // Destructor
        ~ResourceHolder()
        {
            Console.WriteLine("ResourceHolder destroyed.");
            // Clean up resources here (e.g close a file, release memory, etc)
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ResourceHolder holder = new ResourceHolder();
            // Use the Resource Holder
        }
    }
}
