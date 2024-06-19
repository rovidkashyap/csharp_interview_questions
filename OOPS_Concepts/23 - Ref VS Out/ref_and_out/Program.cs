using System;

namespace ref_and_out
{
    // In C# `ref` and `out` keywords are used to pass arguments to methods by reference, rather than by value.
    // This allow the method to modify the argument's value and have that modification reflected outside the method.

    // 'Ref' Keyword -

    // The 'ref' keyword is used to pass an argument by reference. This means any changes made to the parameter
    // inside the method will be reflected in calling environment.
    // The variable passed as 'ref' parameter must be initialized befire it passed to the method.

    // 'Out' Keyword -

    // This is similar to 'ref' keyword, but is used to indicate that the method is expected to initialize the argument.
    // The variable passed to an `out` parameter does not need to initialize before being passed to the method.

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- PASS VALUE USING REF KEYWORD -------------");
            int number = 5;
            Console.WriteLine("Before Calling the method: " + number);  //Output: 5

            // Call the method with 'ref' keyword
            ModifyValue(ref number);

            Console.WriteLine("After calling the method: " + number);   // Output: 10

            Console.WriteLine("\n\n----------------- PASS VALUE USING OUT KEYWORD ---------------");
            int num = 20;
            Console.WriteLine("Before Calling the Method: " + num);     // Output: 20

            // Call the method with 'out' keyword
            InitializeValue(out number);

            Console.WriteLine("After calling the method: " + num);

        }

        // 'number' variable is passed to 'ModifyValue' method using ref keyword
        static void ModifyValue(ref int value)
        {
            // This will double the value of 'number' and changes reflect outside the method.
            value *= 2;     // This will change the original value
        }

        static void InitializeValue(out int value)
        {
            value = 10; // This value must be assigned before the method returns
        }
    }
}
