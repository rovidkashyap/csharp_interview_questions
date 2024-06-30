using System;

namespace throw_and_throwex
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        void ExampleMethod()
        {
            try
            {
                CauseException();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Using throw:");
                throw; // Preserve the stack trace
            }
        }

        void ExampleMethodWithEx()
        {
            try
            {
                CauseException();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Using throw ex:");
                throw ex;   // Reset the stack trace
            }
        }

        void CauseException()
        {
            throw new InvalidOperationException("An error occurred.");
        }
    }
}
