using System.Collections.Generic;
using System;

namespace indexer_vs_dictionary_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, both indexers and dictionaries are used to access elements using keys, but they
            // serve different purposes and have distinct characteristics.

            // Indexer

            var myBooks = new BookCollection();
            myBooks[0] = "C# Programming";
            myBooks[1] = "ASP.NET Core";

            Console.WriteLine(myBooks[0]);
            Console.WriteLine(myBooks[1]);

            // Dictionary
            // Collection of key/value pairs that are organised based on the hash code of the key. It
            // provides fas lookups, additions and removals based on keys.

            #region Dictionary

            var dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "C# Programming");
            dictionary.Add(2, "ASP.NET Core");

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary[2]);

            if(dictionary.ContainsKey(3))
            {
                Console.WriteLine(dictionary[3]);
            }
            else
            {
                Console.WriteLine("Key 3 not found.");
            }

            // TryGetValue usage
            if(dictionary.TryGetValue(2, out var value))
            {
                Console.WriteLine(value);
            }

            #endregion
        }
    }

    #region Indexer

    public class BookCollection
    {
        private List<string> books = new List<string>();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Count)
                {
                    return books[index];
                }
                throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index >= 0 && index < books.Count)
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

    #endregion

}
