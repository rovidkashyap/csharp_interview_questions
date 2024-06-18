using System;

namespace CallByReference
{

    // CALL BY REFERENCE
    // A Reference of the value is passed to the method.
    // Changes made to the parameter inside the method affect the original argument.
    // Passing the reference to the argument, the original value is modified by the method.

    public class CallByReference
    {
        public void ChangeValue(ref int number)
        {
            number = 100;           // This change affects the original argument
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int originalNumber = 50;
            CallByReference example = new CallByReference();

            Console.WriteLine("Before Call By Reference: " + originalNumber);       // Outputs: 50
            example.ChangeValue(ref originalNumber);
            Console.WriteLine("After Call By Reference: " + originalNumber);        // Outputs: 100
        }
    }
}
