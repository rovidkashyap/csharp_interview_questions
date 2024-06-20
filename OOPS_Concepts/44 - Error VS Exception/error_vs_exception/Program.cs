using System.IO;
using System;

namespace error_vs_exception
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Code that may throw an exception
                string content = File.ReadAllText("nonexistentfile.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                // Cleanup code
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
