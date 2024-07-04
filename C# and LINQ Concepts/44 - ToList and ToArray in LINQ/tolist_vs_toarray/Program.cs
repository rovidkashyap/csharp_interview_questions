using System.Collections.Generic;
using System.Linq;

namespace tolist_vs_toarray
{
    internal class Program
    {
        // In LINQ, ToList() and ToArray() are both methods used to convert a sequence (such as the
        // result of a LINQ query) into different types of collections (List<T> and T[]
        // respectively).

        // They serve similar purposes but differ in the type of collection they produce.

        // 1. `ToList()`

        //          It creates a new List<T> containing all elements from the source sequence.
        //          Lists allow for dynamic resizing and are generally more flexible for further
        //          manipulation or enumeration compared to arrays.

        // 2. `ToArray()`

        //          It creates a new array containing all elements from the source sequence.
        //          Arrays have fixed sizes and are generally faster for indexed access but
        //          less flexible in terms of resizing

        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 5); // Generates { 1, 2, 3, 4, 5 }

            List<int> list = numbers.ToList(); // Converts IEnumerable<int> to List<int>

            int[] array = numbers.ToArray(); // Converts IEnumerable<int> to int[]
        }

        // Key Differences

        // 1. ToList() produces a List<T> (a dynamically resizable collection), while ToArray()
        //    produces a fixed-size T[] array.

        // 2. Arrays (T[]) are generally faster for indexed access due to their contiguous memory
        //    allocation, while List<T> may be slower for large collections due to dynamic resizing
        //    operations.

        // When to Use Each

        // Use `ToList()`

        //      - When you need to work with a collection that requires dynamic resizing or
        //        additional list operations.

        //      - When you need to work with a collection that requires dynamic resizing or
        //        additional list operations.

        // Use `ToArray()`

        //      - When you need a fixed-size collection or when performance for indexed access is
        //        critical.

        //      - When you want to ensure immutability of the collection once created.
    }
}
