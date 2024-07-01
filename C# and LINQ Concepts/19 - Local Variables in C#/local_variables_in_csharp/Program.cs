using System;

namespace local_variables_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Local variables are variables that are declared within a method, constructor, or block
            // and are only accessible within that scope. They are created when the method,
            // constructor, or block is entered and destroyed when it is exited. These variables
            // are not accessible from outside their scope.

            int number = 10;        // Local variable declared and initialized

            if(number > 5)
            {
                string message = "Number is greater than 5";    // Local variable in if block
                Console.WriteLine(message);

                // The following line would cause a compilation error because `message` is not in 
                // scope here
                // Console.WriteLine(message);

                for(int i = 0; i < number; i++)
                {
                    Console.WriteLine(i);
                }

                // The following line would cause a compilation error because `i` is not in scope here
                // Console.WriteLine(i);

                // `number` is a local variable declared and initialized in the `Main` method.

                // `message` is a local variable within the `if` block and is not accessible outside
                // of this block

                // `i` is a local variable withtin the `for` loop and is not accessible outside the loop.
            }
        }
    }
}
