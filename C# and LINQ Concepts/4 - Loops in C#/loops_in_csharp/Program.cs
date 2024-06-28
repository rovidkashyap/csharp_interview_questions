using System;

namespace loops_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, there are several types of loops that you can use to repeat a block of code.

            // 1. `for` Loop
            // 2. `foreach` Loop
            // 3. `while` Loop
            // 4. `do-while` Loop

            // `for` Loop - when you know in advance how many times you want to execute a statement or
            //              a block of statement.

            Console.WriteLine("------------------- For Loop -------------------");
            for (int i =0; i < 5; i++)
            {
                Console.Write($"Iteration {i}");
            }

            // `foreach` loop - is used to iterate over the elements of collection (like array or list).
            
            Console.WriteLine("\n\n----------------- Foreach Loop -------------------");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.Write(fruit + " ");
            }

            // `while` loop - is used to execute a block of statement as long as a specified condition
            //                  is true.

            Console.WriteLine("\n\n ------------------ While Loop --------------------");
            int j = 0;

            while(j < 5)
            {
                Console.Write($"Iteration {j}");
                j++;
            }

            // do-while loop - is similar to while loop, but it guarantees that the block of code will
            //                  be executed atleast once.

            Console.WriteLine("\n\n ------------------- Do While Loop -------------------");
            int k = 0;

            do
            {
                Console.Write($"Iteration {k}");
                k++;
            } while (k < 5);

            Console.ReadLine();
        }
    }
}
