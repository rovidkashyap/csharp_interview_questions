using System;
using System.Runtime.InteropServices;

namespace func_and_action
{
    // `Func` and `Action` are predefined generic delegates provided by the .Net Dramework that simplify the declaration and use of delegates.
    // `Func` - It Encapsulate a method that returns a value.
    // `Func` delegate can take upto 16 input parameters and must return a value.
    // `Func` - The last type parameter specifies the return type.

    // `Action` - Encapsulate the method that does not return a value.
    // `Action` delegates can take upto 16 input parameters and do not return a value.

    public class Program
    {
        static void Main(string[] args)
        {
            // Func can takes two integers and returns their sum
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(3, 4);
            Console.WriteLine($"Sum: {result}");    // Output: Sum 7 

            // Func that takes a string and returns its length
            Func<string, int> getLength = str => str.Length;
            int length = getLength("Hello, World");
            Console.WriteLine($"Length: {length}"); // Output: Length: 12

            // Action that takes a string and prints it
            Action<string> printMessage = message => Console.Write(message);
            printMessage("Hello World!");       // Output: Hello World

            // Action that takes two integers and prints their sum
            Action<int, int> printSum = (a, b) => Console.WriteLine($"Sum: {a + b}");
            printSum(3, 4);                     // Output: Sum 7
        }
    }
}
