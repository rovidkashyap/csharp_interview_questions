using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace first_vs_firstordefault_in_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In LINQ, both First() and FirstOrDefault() are methods used to retrieve the first
            // element of a sequence that satisfies a specified condition (or the first element in
            // the sequence if no condition is specified). However, there are key differences between
            // the two methods in terms of their behavior when no elements are found.

            #region First()

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // This will return the first element (1)
            int firstNumber = numbers.First();

            // This will return the first element that is greater than 3 (4)
            int firstGreaterThanThree = numbers.First(n => n > 3);

            // This will throw InvalidOperationException because there is no element greater than 5
            int firstGreaterThanFive = numbers.First(n => n > 5);

            Console.WriteLine(firstNumber);                          // Output: 1
            Console.WriteLine("\n" + firstGreaterThanThree + "\n");  // Output: 4
            Console.WriteLine("\n" + firstGreaterThanFive);          // Output: InvalidOperationException
            Console.ReadLine();

            #endregion

            #region FirstOrDefault()

            // This will return the first element (1)
            int firstNumberOrDefault = numbers.FirstOrDefault();

            // This will return the first element that is greater than 3 (4)
            int firstGreaterThanThreeOrDefault = numbers.FirstOrDefault(n => n > 3);

            // This will return the default value for int (0) because there is no element greater than 5
            int firstGreaterThanFiveOrDefault = numbers.FirstOrDefault(n => n > 5);

            // Example with a reference type
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            // This will return the first element ("Alice")
            string firstOrDefaultName = names.FirstOrDefault();

            // This will return the default value for string (null) because there is no element "Dave"
            string firstOrDefaultNonExistentName = names.FirstOrDefault(name => name == "Dave");

            Console.WriteLine(firstNumberOrDefault);                // Output: 1
            Console.WriteLine(firstGreaterThanThreeOrDefault);      // Output: 4
            Console.WriteLine(firstGreaterThanFiveOrDefault);       // Output: 0
            Console.WriteLine(firstOrDefaultName);                  // Output: Alice
            Console.WriteLine(firstOrDefaultNonExistentName);       // Output: 

            #endregion
        }
    }
}
