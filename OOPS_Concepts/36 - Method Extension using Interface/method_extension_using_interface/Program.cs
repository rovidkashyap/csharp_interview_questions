using System;

namespace method_extension_using_interface
{
    // No, It is not possible to achieve method extension using Interface.
    // but method extension is typically achieved using extension methods rather than interfaces.
    // Extension methods allow you to add new method to existing types without modifying the original
    // type or creating a new derived type.
     
    // Extension methods are defined as static methods within static class.
    // They are marked with the `this` keyword before the first parameter, which speciify the type being extended.

    public static class StringExtensions
    {
        public static string Reverse(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static bool IsPalindrome(this string input)
        {
            string reversed = input.Reverse();
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Rovid";

            // Using Extension Methods
            string reversedText = text.Reverse();
            bool isPalindrome = text.IsPalindrome();

            Console.WriteLine($"Original text: {text}");
            Console.WriteLine($"Reversed text: {reversedText}");
            Console.WriteLine($"Is Palindrome: {isPalindrome}");
        }
    }
}
