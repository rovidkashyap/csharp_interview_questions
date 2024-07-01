using System;
using System.Linq;

namespace where_clause_and_let_Clause
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                `Where` and `Let` clause are important components of LINQ (Language Integrated Query)
                in C#. They allow for filtering and creating intermediate results within a query.

                The `Where` clause is used to filter elements in a collection based on a specified 
                condition. It is similar to the `WHERE` clause in SQL. Only the elements that satisfy the
                condition specified in the `Where` clause are included in the result set.
            */

            #region Where Clause

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Filtering numbers that are even
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            #endregion

            /*
                `Let` Clause is used to introduce a new range variable and store the result of a sub-
                expression for use later in the query. It is particulary useful for complex expressions
                that are used multiple times within a query, as it can improve readability and efficiency.

            */

            #region Let Clause

            string[] words = { "cherry", "apple", "blueberry" };

            // Creating a new range variables `wordLength` to store the length of each word
            var wordInfo = from word in words
                           let wordLength = word.Length
                           select new { Word = word, Length = wordLength };

            Console.WriteLine("Word Info:");
            foreach (var info in wordInfo)
            {
                Console.WriteLine($"Word: {info.Word}, Length: {info.Length}");
            }

            #endregion

            // Where Clause are used to filter the elements based on the condition.
            // Let Clause are used to create a new range variable to store the result of a sub-expression
            // for use later in the query, improving readability and efficiency.
        }
    }
}
