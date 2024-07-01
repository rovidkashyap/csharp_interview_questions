using System;
using System.Collections.Generic;

namespace indexer_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Indexers in C# allow objects to be indexed in a manner similar to arrays. They enable
            // instances of a class or a struct to be accessed using the array-like syntax. Indexers
            // are typically used to provide an intuitive way to access collections or other data
            // structures that belong to a class or struct.

            BookCollection myBooks = new BookCollection();
            myBooks[0] = "C# Programming";      // Adds "C# Programming" to the collection
            myBooks[1] = "ASP.NET Core";        // Adds "ASP.NET Core" to the collection

            Console.WriteLine(myBooks[0]);  // Outputs: C# Programming
            Console.WriteLine(myBooks[1]);  // Outputs: ASP.NET Core

            try
            {
                Console.WriteLine(myBooks[2]);  // Throws IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);   // Outputs: Invalid index
            }
        }
    }

    public class BookCollection
    {
        private List<string> books = new List<string>();

        public string this[int index] 
        {
            get 
            {
                if(index >= 0 && index < books.Count)
                {
                    return books[index];
                }
                throw new IndexOutOfRangeException("Invalid index");
            }
            set 
            {
                if(index >= 0 && index < books.Count)
                {
                    books[index] = value;
                }
                else if (index == books.Count)
                {
                    books.Add(value);
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }
    }
}
