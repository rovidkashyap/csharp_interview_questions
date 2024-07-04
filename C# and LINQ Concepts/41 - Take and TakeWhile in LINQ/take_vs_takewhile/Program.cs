using System.Collections.Generic;
using System.Linq;

namespace take_vs_takewhile
{
    internal class Program
    {
        // In LINQ, Take() and TakeWhile() are used to return a subset of elements from a sequence,
        // but they differ in how they determine which elements to return.

        // 1. `Take()`:

        //      It simply returns the first count elements from the sequence, regardless of the
        //      values of those elements.

        // 2. `TakeWhile()`:

        //       It returns elements from the start of the sequence until the predicate returns
        //       false for the first time. After that, no further elements are considered, even
        //       if the predicate would be true for subsequent elements.

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Using `Take()`

            var firstThree = numbers.Take(3); // Returns { 1, 2, 3 }

            // Using `TakeWhile()`

            var takeWhileLessThanFive = numbers.TakeWhile(n => n < 5); // Returns { 1, 2, 3, 4 }
        }

        // In this example, Take(3) returns the first three elements of the list, regardless of
        // their values. On the other hand, TakeWhile(n => n < 5) returns elements from the start
        // of the list until it encounters an element that is not less than 5. Once it encounters
        // 5, it stops and does not include any more elements, even though some subsequent elements
        // (like 3 and 4) would satisfy the condition.

        // Summary

        // `Take()`: Use this when you need a fixed number of elements from the start of a sequence.

        // `TakeWhile()`: Use this when you need elements from the start of a sequence that satisfy
        //                a certain condition and want to stop as soon as the condition is not met.
    }
}
