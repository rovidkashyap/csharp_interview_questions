using System;
using System.Collections.Generic;
using System.Linq;

namespace theby_clause_in_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  `ThenBy` clause is used to perform secondary sorting on a sequence of elements that
            //  have already been sorted by a primary key using the OrderBy clause.

            //  The ThenBy clause is essential when you need to sort by multiple criteria, providing
            //  a way to specify the subsequent sort orders after the initial sort.

            List<Person> people = new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe" },
                new Person { FirstName = "Jane", LastName = "Doe" },
                new Person { FirstName = "Alice", LastName = "Smith" },
                new Person { FirstName = "Bob", LastName = "Smith" }
            };

            var sortedPeople = people.OrderBy(p => p.LastName)
                                     .ThenBy(p => p.FirstName);

            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.LastName}, {person.FirstName}");
            }
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    
}
