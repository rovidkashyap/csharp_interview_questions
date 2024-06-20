using System;
using System.Collections.Generic;

namespace yield_keyword
{
    // `yield` keyword in c# is used in iterator to provide a value to the enumerator object.
    // when the `yield return` statement is encountered, the current location of the code is preserved,
    // and execution is halted.

    // 1. `Yield` Keyword return values one at a time and can save memory and improve performance
    // when dealing with large data sets.
    // 2. `Yield` Keyword simplified the implementation of complex iteration logic without the need
    // for temporary collections.
    // 3. `Yield` Keyword makes it easier to create custom iterators for your own collection types.

    // `yield return` returns one element of a sequence at a time.
    // `yield break` ends the iteration.

    public class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in GenerateFibonacci(10))
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }

        public static IEnumerable<int> GenerateFibonacci(int count)
        {
            int first = 0, second = 1;

            for(int i = 0; i < count; i++)
            {
                yield return first; // return the current Fibonacci number
                int temp = first;
                first = second;
                second = temp + first;
            }
        }
    }
}
