using System;

namespace continue_vs_break_in_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, `continue` and `break` are control flow statements used within loops (`for`,
            // `foreach`, `while`, `do-while` to alter the normal execution flow.

            // `continue` statement - skip the remaining statements in the current iteration of the
            //                        loop and proceeds to the next iteration.

            for(int i = 0; i <10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;   // Skip the rest of the loop body for even numbers
                }
                Console.WriteLine(i);   // This will print only odd numbers
            }

            // This program will skip the even numbers and continue with odd numbers.

            // `break` statement - terminates the loop immediately and transfers control to the statement
            //                     following the loop.
            //                   - Use `break` if you want to exit the loop completely based on condition.

            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;      // Exit the loop when i equals 5
                }
                Console.WriteLine(i);   // This will print numbers 0 through 4
            }

            // continue - Loop cotinues with the next iteration
            // break - Loop stops executing.
        }
    }
}
