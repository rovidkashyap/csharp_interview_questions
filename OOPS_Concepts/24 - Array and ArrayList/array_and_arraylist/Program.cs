using System;
using System.Collections;

namespace array_and_arraylist
{
    // In C#, Both 'Array' and 'ArrayList' are used to tore colections of items, but they have significant difference.
    
    // ARRAY - 

    // 1. Array are Fized in Size.  Once it created, its size is fixed.
    // 2. Array provide type-safety, meaning they can only store elements of a specific types.
    //      this ensures that all elements in the array are of the same type, providing compile-time checking.
    // 3. Array provide better performance compared to 'ArrayList' due to their type safety and fixed size.

    // ARRAYLIST - 

    // 1. ArrayList can dynamically resize itself when elements are added or removed. This provides felxibility when the number
    // of elements is not known in advanced.
    // 2. ArrayList is non-generic collection, meaning it can store elements of any type, also means it is not type-safe.
    // 3. Since ArrayList stores objects, value types are boxed when added to the list and unboxed when retrieved, which impact its performance.


    // List<T> combines the best features of 'Array' and 'ArrayList', providing a dynamically resizeable type-safe collection.

    public class Program
    {
        static void Main(string[] args)
        {
            // ARRAY EXAMPLE
            Console.WriteLine("------------------- USING ARRAY ------------------");
            int[] number = new int[3];
            number[0] = 1;
            number[1] = 2;
            number[2] = 3;

            // Prints array elements
            foreach (int num in number) 
            {
                Console.Write(num + " ");
            }

            // ARRAYLIST EXAMPLE
            Console.WriteLine("\n---------------- USING ARRAYLIST -----------------");
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            // Print ArrayList elements
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
