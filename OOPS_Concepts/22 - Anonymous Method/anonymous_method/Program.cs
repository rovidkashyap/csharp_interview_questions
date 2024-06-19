using System;

namespace anonymous_method
{
    // In C#, Anonymous Method are the method without name that is defined using the `delegate`
    // keyword directly within the code.
    // Anonymous methods provides a way to define inline methods at the point where they are needed
    
    public class Program
    {
        // Define a delegate
        public delegate void DisplayMessage(string message);

        static void Main(string[] args)
        {
            // Assign an anonymous method to the delegate
            DisplayMessage messageDelegate = delegate (string message)
            {
                Console.WriteLine(message);
            };

            // Invoke the delegate
            messageDelegate("Hello, World!");
        }
    }
}
