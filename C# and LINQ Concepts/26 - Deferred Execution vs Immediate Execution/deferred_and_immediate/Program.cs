using System;
using System.Collections.Generic;
using System.Linq;

namespace deferred_and_immediate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In LINQ, the concepts of Deferred Execution and Immediate Execution refer to how and
            // when queries are executed against a data source.

            // Deferred Execution - means that the query execution is delayed until the results are
            //                      actually enumerated (accessed or retrieved).

            //                    - When you create a LINQ query using deferred execution, the query
            //                      is not executed immediately. Instead, the query definition (the
            //                      LINQ expression) is stored and remembered.

            //                    - Commonly used with `IEnumerable<T>` and `IQueryable<T>` interfaces.

            #region Deferred Execution

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Query is defined but not executed yet (deferred)
            var query = numbers.Where(n => n % 2 == 0);

            // Execution happens when the result is enumerated (e.g., in a foreach loop)
            foreach (var number in query)
            {
                Console.WriteLine(number);  // Output: 2, 4
            }

            #endregion

            // Immediate Execution - means that the query is executed as soon as it is defined and
            //                       not delayed until later enumeration.

            //                     - When you create a LINQ query using Immediate execution, the query
            //                       is executed right away, and the results are stored in memory.

            //                     - Occurs when methods like `ToList()`, `ToArray()`, `Count()`, `First()`
            //                       are called on a LINQ query.

            #region Immediate Execution

            List<int> mynumbers = new List<int> { 1, 2, 3, 4, 5 };

            // Immediate execution with ToList()
            List<int> evenNumbers = mynumbers.Where(n => n % 2 == 0).ToList();

            // Result is immediately available in 'evenNumbers'
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);  // Output: 2, 4
            }

            #endregion

        }
    }
}
