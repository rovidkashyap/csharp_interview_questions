using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;

namespace ienumerable_vs_iqueryable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            
                `IEnumerable` and `IQueryable` are two important interfaces in C#, used for data querying,
                but they serve different purposes and have distinct characterstics.

                `IEnumerable<T>` - represent forward-only cursor of an sequence of elements.
                              - suitable for in-memory collection querying.
                              - used deferred execution, but the query execution is done in memory.
                              - when you enumerate a sequence, the data is pulled into memory and then
                                the operations (filtering, ordering, etc.) are performed.
                              - best for querying collections like (arrays, lists and other in-memory
                                data structures).
                              - This Filters the records on the client side. (Client Side Filtering).

                `IQueryable<T> - Inherits from `IEnumerable<t>`.
                               - used deffered execution, and the actual query is performed at data source.
                               - best for querying remote data source like databases or web services.
                               - more effecient for large datasets since the query is executed on the data
                                 server, reduce the amunt of data transferred to the client.
                               - This filters the records on the data source. (Server Side Filtering).
            */

            #region IEnumerable Example

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            IEnumerable<int> query = numbers.Where(n => n > 2);

            foreach (int number in query)
            {
                Console.WriteLine(number);
            }

            #endregion

            #region IQuerable Example
            /*
            using (var context = new MyDbContext())
            {
                IQueryable<Customer> query = context.Customer.Where(c => c.City == "Seattle");

                foreach (Customer customer in query)
                {
                    Console.WriteLine(customer.Name);
                }
            }
            */
            #endregion
        }
    }
}
