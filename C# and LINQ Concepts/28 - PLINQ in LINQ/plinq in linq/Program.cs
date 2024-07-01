using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plinq_in_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // PLINQ stands for Parallel LINQ. It is an extension of LINQ (Language Integrated Query)
            // introduced in .NET Framework 4.0 and later versions, specifically designed to support
            // parallel execution of LINQ queries. PLINQ enables developers to leverage multi-core
            // processors and perform query operations concurrently, thereby potentially improving
            // performance for data-intensive operations.

            // Key Features of PLINQ:

            // Parallel Execution: PLINQ automatically partitions the data and distributes the query
            //                     operations across multiple threads, utilizing all available CPU cores.
            //                     This parallelism can significantly speed up query processing for large
            //                     datasets or computationally intensive operations.

            // Integration with LINQ: PLINQ seamlessly integrates with LINQ syntax and operators. This
            //                        means developers can use familiar LINQ query expressions and
            //                        methods(Where, Select, OrderBy, etc.) while benefiting from
            //                        parallel execution capabilities.

            // Asynchronous and Deferred Execution: Like LINQ, PLINQ supports deferred execution, meaning
            //                                      query operations are not executed until the results
            //                                      are actually enumerated(accessed or retrieved). This
            //                                      allows for dynamic query composition and optimization.


            // Task Parallel Library(TPL) Integration: PLINQ is built on top of the Task Parallel
            //                                         Library(TPL), which provides robust support for
            //                                         managing and scheduling concurrent tasks.TPL
            //                                         handles the underlying thread management and
            //                                         synchronization, making it easier to write
            //                                         parallelized code without explicit thread
            //                                         management.

            // Performance Considerations: While PLINQ can improve performance by leveraging parallelism,
            //                             it is essential to consider factors such as data partitioning
            //                             overhead, synchronization costs, and load balancing.Proper
            //                             testing and profiling are necessary to ensure that parallel
            //                             execution indeed provides performance benefits in specific
            //                             scenarios.

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Parallel LINQ query to filter even numbers
            var evenNumbers = numbers.AsParallel()
                                     .Where(n => n % 2 == 0)
                                     .Select(n => n);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
