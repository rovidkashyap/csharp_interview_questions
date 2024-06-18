using System;

namespace CallByValue
{

    // CALL BY VALUE
    // A copy of the value is passed to the method
    // Changes made to the parameter inside the method do not affect the original argument.
    // Passing a copy of the argument, the original value remains unchanged.

    public class CallByValue
    {
        public void ChangeValue(int number)
        {
            number = 100;       // This change is local to the method
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int originalNumber = 50;
            CallByValue example = new CallByValue();

            Console.WriteLine("Before Call by Value: " + originalNumber);       // Outputs: 50
            example.ChangeValue(originalNumber);
            Console.WriteLine("After Call by Value: " + originalNumber);        // Outputs: 50
        }
    }
}
