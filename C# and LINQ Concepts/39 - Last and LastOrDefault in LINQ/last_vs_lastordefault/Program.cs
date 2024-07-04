using System;
using System.Collections.Generic;
using System.Linq;

namespace last_vs_lastordefault
{
    internal class Program
    {

        // In LINQ (Language-Integrated Query), both Last() and LastOrDefault() are used to retrieve
        // the last element of a sequence. However, there is a key difference in their behavior when
        // the sequence is empty or no element satisfies the condition provided.

        // 1. `Last()`:

        //          Retrieves the last element of a sequence
        //          If sequence is empty or if no element satisfies condition then it throws an error
        //          (`InvalidOperationException`).

        // 2. `LastOrDefault()`:

        //          Retrieves the last element of a sequence
        //          If sequence if empty or no elements satisfies the condition then it doesn't throw
        //          error and returns value of type (`default(T)`).

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> emptyList = new List<int>();

            // Using `Last()`:

            int lastNumber = numbers.Last();        
            Console.WriteLine(lastNumber);                  // Output: 5

            int lastNumberInEmptyList = emptyList.Last();   
            Console.WriteLine(lastNumberInEmptyList);       // Throws InvalidOperationException

            // Using `LastOrDefault()`:

            int lastNumberOrDefault = numbers.LastOrDefault();  
            Console.WriteLine(lastNumberOrDefault);                 // Output: 5

            int lastNumberOrDefaultInEmptyList = numbers.LastOrDefault();
            Console.WriteLine(lastNumberOrDefaultInEmptyList);      // Output: 0 (default value for int)
        }
    }
}
