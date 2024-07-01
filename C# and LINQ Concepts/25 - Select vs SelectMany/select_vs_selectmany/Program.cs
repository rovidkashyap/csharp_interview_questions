using System;
using System.Collections.Generic;
using System.Linq;

namespace select_vs_selectmany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            `Select` - Use `Select` when you want to change each item in a list into something else.
                     - If you have a list of numbers and you want to turn each number into its square 
                       (like turning 2 into 4 and 3 into 9), you'd use Select.            


            `SelectMany` - Use SelectMany when you have a list of lists and you want to combine them 
                           all into one big list.
                         - Imagine you have a list where each item is another list of numbers. If you 
                           use SelectMany, it will take all those small lists and put all their 
                           numbers together into one big list.
            
             */

            #region SELECt<T>

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Selecting each number and transforming it into its square
            var squares = numbers.Select(num => num * num);

            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }

            #endregion

            #region SELECTMANY<T>

            List<List<int>> nestedList = new List<List<int>>
            {
                new List<int>{ 1, 2 },
                new List<int>{ 3, 4 },
                new List<int>{ 5, 6 }
            };

            // Flatterning the nested lists into a single sequence
            var flattened = nestedList.SelectMany(list => list);

            foreach (var number in flattened)
            {
                Console.WriteLine(number);
            }

            #endregion
        }
    }
}
