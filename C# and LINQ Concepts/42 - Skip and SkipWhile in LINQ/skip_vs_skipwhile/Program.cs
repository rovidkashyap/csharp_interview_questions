using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace skip_vs_skipwhile
{
    internal class Program
    {
        // n LINQ, both Skip() and SkipWhile() are used to skip a specified number of elements or
        // elements that satisfy a condition from the beginning of a sequence. However, they
        // differ in how they determine which elements to skip.

        // `Skip()`:

        // It ignores the first count elements of the sequence and returns the remaining elements.
        // If the sequence contains fewer elements than count, an empty sequence is returned.

        // `SkipWhile()`:

        // It skips elements from the start of the sequence until the predicate returns false for
        // the first time. After that, it returns all remaining elements from the sequence,
        // starting from the element for which the predicate first returned false.

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Using `Skip()`

            var skipThree = numbers.Skip(3); // Skips { 1, 2, 3 } and returns { 4, 5, 6, 7, 8, 9, 10 }

            // Using `SkipWhile()`

            var skipWhileLessThanFive = numbers.SkipWhile(n => n < 5); 
            // Skips { 1, 2, 3, 4 } and returns { 5, 6, 7, 8, 9, 10 }
        }

        // In this example, Skip(3) skips the first three elements of the list and returns the rest.
        // On the other hand, SkipWhile(n => n< 5) skips elements from the start of the list until
        // it encounters an element that is not less than 5. Once it encounters 5, it starts
        // returning all subsequent elements, including 5.

        // Summary

        // `Skip()`: Use this when you need to skip a fixed number of elements from the start of a
        // sequence.

        // `SkipWhile()`: Use this when you need to skip elements from the start of a sequence that
        // satisfy a certain condition and want to start including elements as soon as the condition
        // is not met.

        // These methods are useful for scenarios where you need to ignore certain initial elements
        // based on a condition or a fixed count.
    }
}
