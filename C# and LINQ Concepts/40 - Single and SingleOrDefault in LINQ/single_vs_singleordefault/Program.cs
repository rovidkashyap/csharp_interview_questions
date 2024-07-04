using System.Collections.Generic;
using System.Linq;

namespace single_vs_singleordefault
{
    internal class Program
    {
        // In LINQ, Single() and SingleOrDefault() are used to retrieve a single element from a
        // sequence. They both ensure that the sequence contains exactly one element that matches
        // the specified condition (if provided), but they handle cases where the sequence does
        // not meet this criterion differently.

        // 1. `Single()`:

        //      Retrieves the single element of a sequence.
        //       if the sequence is empty or contains more than one element throws an exception
        //      (`InvalidOperationException`).

        // 2. `SingleOrDefault()`:

        //      Retrieves the single element of a sequence.
        //      Returns the default value for the type (default(T)), such as null for reference
        //      types, 0 for integers, etc., if the sequence is empty.
        //      Throws an exception (InvalidOperationException) if more than one element is found.

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> singleElementList = new List<int> { 42 };
            List<int> emptyList = new List<int>();
            List<int> duplicates = new List<int> { 1, 2, 2, 4, 5 };

            // Use `Single()`:

            int singleElement = singleElementList.Single(); // Returns 42
            int singleElementInEmptyList = emptyList.Single(); // Throws InvalidOperationException
            int singleElementInDuplicates = duplicates.Single(); // Throws InvalidOperationException

            int singleEven = numbers.Single(n => n % 2 == 0 && n > 4); // Throws InvalidOperationException (no such element)
            int singleTwo = numbers.Single(n => n == 2); // Returns 2
            int singleDuplicateTwo = duplicates.Single(n => n == 2); // Throws InvalidOperationException

            // Use `SingleOrDefault()`:

            int singleElementOrDefault = singleElementList.SingleOrDefault(); // Returns 42
            int singleElementOrDefaultInEmptyList = emptyList.SingleOrDefault(); // Returns 0 (default value for int)
            int singleElementOrDefaultInDuplicates = duplicates.SingleOrDefault(); // Throws InvalidOperationException

            int singleEvenOrDefault = numbers.SingleOrDefault(n => n % 2 == 0 && n > 4); // Returns 0 (default value for int)
            int singleTwoOrDefault = numbers.SingleOrDefault(n => n == 2); // Returns 2
            int singleDuplicateTwoOrDefault = duplicates.SingleOrDefault(n => n == 2); // Throws InvalidOperationException
        }

        // Use Single() when you want to ensure exactly one element exists and prefer an exception
        // if the sequence is empty or contains more than one element.

        // Use SingleOrDefault() when you want to allow for the possibility that the sequence might
        // be empty and return a default value in that case, but still want an exception if more
        // than one element matches the condition.

    }
}
