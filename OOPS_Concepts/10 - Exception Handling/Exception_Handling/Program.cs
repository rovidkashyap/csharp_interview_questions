using System;

namespace Exception_Handling
{
    // Exception Handling in C# is way to handle errors or other exceptional conditions
    // that occur during execution of program.
    // The Primary constructs used for this are 'try', 'catch' and 'finally' and 'throw'.
    public class Program
    {

        // TRY BLOCK - Contains Code that might throw an exception.
        // In this case, it promopt user to enter a number and attempts to divide 10 by that number.

        // CATCH BLOCK - Handles specific exceptions that are thrown in the try block.
        // DivideByZero Exception - This is thrown if the user enters '0' as the unput.
        // FormatException - This is thrown if user enters a value that cannot be converted to an integer.
        // Exception - This is a generic catch-all for any other exceptions not specifically caught by the earlier catch blocks.

        // FINALLY BLOCK - Code that will run whether an exception is thrown or not.
        // This is typically used for cleanup operations, like closing files or releasing resources.

        static void Main(string[] args)
        {
            try
            {
                // Code that may cause exception
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                // This will cause a DivideByZeroException if number is 0
                int result = 10 / number;
                Console.WriteLine($"The result is {result}");
            }
            catch(DivideByZeroException ex)
            {
                // Handle specific exception
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine($"Exception message: {ex.Message}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Error: Input is not a valid number.");
                Console.WriteLine($"Exception message: {ex.Message}");
            }
            catch(Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Exception message: {ex.Message}");
            }
            finally
            {
                // Code that runs regardless of whether an exception was thrown or not
                Console.WriteLine("This block is always executed.");
            }

            Console.WriteLine("Program execution continues...");
        }
    }
}
