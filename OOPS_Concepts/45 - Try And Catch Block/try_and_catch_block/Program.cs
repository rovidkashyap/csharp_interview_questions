using System.IO;
using System;

namespace try_and_catch_block
{
    // The try/catch block in C# is a fundamental construct used for exception handling. It allows
    // you to write code that might throw exceptions and provide specific code to handle those
    // exceptions, ensuring that the program can handle unexpected conditions gracefully and
    // continue to operate.

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Attempt to read a file that may not exist
                string content = File.ReadAllText("nonexistentfile.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access denied: {ex.Message}");
            }
            catch (Exception ex)
            {
                // General exception handler
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
