using System;
using System.Text;

namespace string_and_stringbuilder
{
    // In C#, string and StringBuilder are both used for handling text, but they serve different purposes and have different characteristics.

    // STRING - 

    // 1. String is Immutable sequesnt of characters, which means once object creates it cannot be modified.
    // any operations that appears to modify the string, such as concatenation or replacement, actually created new string.
    // 2. Due to its immutability, It can lead to performance overhead, especially in loops or repetitive operations.

    // STRINGBUILDER -

    // 1. StringBuilder is deigned for scenarios where you need to perform frequesnt modifications to a string.
    // 2. StringBuilder is mutable, which means it can be modified without creating new instances.
    // 3. Provides methods for appending, inserting, removing and replacing characters effeciently.

    public class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            // Concatenation creates a new string
            string result = str1 + " " + str2;

            Console.WriteLine(result);  // Output: Hello World

            // String methods create new strings
            string upper = result.ToUpper();
            Console.WriteLine(upper);   // Output: HELLO WORLD

            // Original string remains unchanged
            Console.WriteLine(result);  // Output: Hello World

            StringBuilder sb = new StringBuilder();

            //Append Strings
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");

            Console.WriteLine(sb.ToString());   // Output: Hello World

            // Modified the StringBuilder
            sb.Replace("World", "Rovid");

            Console.WriteLine(sb.ToString());   // Output: Hello Rovid
        }
    }
}
