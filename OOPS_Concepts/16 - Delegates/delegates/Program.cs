using System;
using System.Runtime.InteropServices;

namespace delegates
{
    // IN C# Delegates are used to pass methods as arguments to other methods, to 
    // define callback methods, and to implement event handling.

    // Some Common Delegate Types
    //1. Single Cast Delegate - A Delegate that can hold only one method.
    //2. Multicast Delegate - A delegate that can hold references to multiple method.
    //3. Func Delegate - A predefined delegate type provided by the .Net Framework for functions that retur a value.
    //4. Action Delegate - A predefined delegate type for methods that do not return a value.

    internal class Program
    {
        // Declare a delegate
        public delegate void MyDelegate(string message);

        static void Main(string[] args)
        {
            // Instantiate Delegate
            MyDelegate del = new MyDelegate(PrintMessage);

            // Invoke the delegate
            del("Hello, Delegates!");

            // Func Delegate Example
            Func<int, int, int> add = (x, y) => x + y;
            int result = add(5, 3);
            Console.WriteLine($"Result: {result}");

            // Action Delegate Example
            Action<string> print = message => Console.WriteLine(message);
            print("Hello, Action Delegates!");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
