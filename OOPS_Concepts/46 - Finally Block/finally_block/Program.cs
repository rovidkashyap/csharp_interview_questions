using System;

namespace finally_block
{
    // The finally block is a powerful feature in C# for ensuring that critical cleanup
    // code runs regardless of whether an exception is thrown. This helps maintain robust
    // and reliable code, especially when dealing with resources that need explicit management.

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("In try block.");
                // This will throw a DivideByZeroException
                int result = 10 / int.Parse("0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }
            finally
            {
                // This block will always execute
                Console.WriteLine("In finally block.");
            }
        }
    }
}
