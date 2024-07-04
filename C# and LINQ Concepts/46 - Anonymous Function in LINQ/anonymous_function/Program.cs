using System.Collections.Generic;
using System.Linq;

namespace anonymous_function
{
    internal class Program
    {
        // In LINQ (Language-Integrated Query), an anonymous function refers to a lambda expression
        // or a delegate that is defined inline without explicitly declaring a method.

        // Anonymous functions are commonly used in LINQ queries to define predicates, projections,
        // and transformations directly within the query syntax.

        // Anonymous functions are particularly useful in LINQ for defining predicates
        // (Where clause), projections (Select clause), sorting (OrderBy clause), and other
        // operations without needing to define separate named methods.

        static void Main(string[] args)
        {
            // Filtering with `Where`
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(x => x % 2 == 0);

            // Projecting with `Select`
            List<string> words = new List<string> { "apple", "banana", "cherry" };
            var lengths = words.Select(word => word.Length);

            // Sorting with `OrderBy`
            List<string> fruits = new List<string> { "apple", "banana", "cherry" };
            var sortedFruits = fruits.OrderBy(fruit => fruit);
        }
    }
}
