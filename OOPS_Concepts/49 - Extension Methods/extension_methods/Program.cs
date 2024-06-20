using System;

namespace extension_methods
{
    // Extension methods in C# are a way to add new functionality to
    // existing types without modifying the original type or creating a
    // new derived type.

    // They allow you to "extend" a type with new methods as if they were
    // part of the original type. This is especially useful for adding
    // utility methods to existing classes, such as those in the .NET
    // Framework or third-party libraries, without changing their source
    // code.

    // 1. Extension Methods are defined in static classes and the methods
    // themselves must be static.
    // 2. The first parameter of an extension method specifies the type it
    // is extending and is preceded by the `this` keyword.

    // Static class to hold the extension method
    public static class StringExtensions
    {
        // Extension method for the string class
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }
            // Split the string into words
            string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, how are you doing today?";
            int wordCount = text.WordCount();   // Calling the extension method
            Console.WriteLine($"Word Count: {wordCount}");
        }
    }
}
