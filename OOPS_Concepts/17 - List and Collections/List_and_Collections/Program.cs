using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices.WindowsRuntime;

namespace List_and_Collections
{
    // In C# `List<T>` and `Collection<T>` both are the part of the `System.Collections.Generics` namespace
    // and provide ways to work with a collection of objects.

    // LIST<T> - 
    
    // 1. It is general purpose collection class that provides methods to manipulate lists
    // of objects. It is designed for performance and ease of use.
    // 2. It is used when you need a dynamic array-like collection that can grow and shrink in size.
    // 3. Optimize with performance with operations such as removing and accessing elements by index.
    // 4. Provide various methods for searching, sorting and manipulating the list, such as
    // 'Add', 'Remove', 'Find', 'Sort', 'Reverse', etc

    // COLLECTION<T> -

    // 1. Collection<T> Provides a base class for custom collections.
    // 2. It is designed to be extended, allowing developers to create collections with custom behavior.
    // 3. Not as optimized for performance as `List<T>`. The focus is on providing a base class for custom collections.
    // 4. Allow for customization by overriding methods such as 'InsertItem', 'RemoveItem', 'SetItem' and 'ClearItems'.

    public class Program
    {
        static void Main(string[] args)
        {
            // Declaring List and iterating using foreach loop
            Console.WriteLine("---------------- CREATING LIST AND ITERATING USING FOREACH LOOP -------------");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Add(6);     // Add an element
            numbers.Remove(3);  // Remove an element

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }

            // Declaring Collections and iterating using foreach loop
            Console.WriteLine("\n\n---------------- CREATING COLLECTION AND ITERATING USING FOREACH LOOP ------------------");
            MyCustomCollection<int> myNumbers = new MyCustomCollection<int> { 1, 2, 3, 4, 5 };
            myNumbers.Add(6);       // Add an Element
            myNumbers.Remove(3);    // Remove an Element

            foreach(int i in myNumbers)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }

    public class MyCustomCollection<T> : Collection<T>
    {
        protected override void InsertItem(int index, T item)
        {
            // Custom Behavior
            Console.WriteLine($"Adding item at index {index}");
            base.InsertItem(index, item);
        }

        protected override void RemoveItem(int index)
        {
            // Custom Behavior
            Console.WriteLine($"Removing item at index {index}");
            base.RemoveItem(index);
        }
    }
}
