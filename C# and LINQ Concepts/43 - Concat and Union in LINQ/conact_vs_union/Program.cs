using System.Collections.Generic;
using System.Linq;

namespace conact_vs_union
{
    internal class Program
    {
        // In LINQ, Concat() and Union() are used to combine multiple sequences into a single
        // sequence, but they differ in how they handle duplicate elements and the resulting
        // sequence.

        // 1. `Concat()`:

        //          It combines two sequences into a single sequence. The resulting sequence
        //          contains all elements from the first sequence followed by all elements from
        //          the second sequence, including duplicates if they exist in either sequence.

        // 2. `Union()`:

        //          It returns a sequence that contains unique elements that appear in either of
        //          the two sequences. Duplicates are removed so that each element appears only
        //          once in the resulting sequence.

        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int> { 3, 4, 5 };

            // Using `Concat()`

            var concatenated = list1.Concat(list2); // Result: { 1, 2, 3, 3, 4, 5 }

            // Using `Union()`

            var unioned = list1.Union(list2); // Result: { 1, 2, 3, 4, 5 }

            // In the result of Union(), the element 3 appears only once, as duplicates are removed.
            // The resulting sequence contains unique elements from both list1 and list2.

            // Summary

            // `Concat()`: Concatenates sequences including duplicates from both sequences.

            // `Union()`: Returns a sequence with unique elements from both sequences, removing
            // duplicates
        }
    }
}
