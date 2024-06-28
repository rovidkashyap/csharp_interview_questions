using System;

namespace valuetype_and_referencetype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type Example
            // It Includes Primiteve Types (`int`, `float`, `bool` and user-defined type like `struct`
            // and `enum`. They directly hold their data, and when you assign one value type variable
            // to another, a copy of the value is made.

            int a = 10;
            int b = a;          // Copy the value of a to b

            Console.WriteLine("-------------------- Value Type Example --------------------");

            Console.WriteLine($"Before change: a = {a}, b = {b}");

            b = 20;             // changes the value of b

            Console.WriteLine($"After change: a = {a}, b = {b}");

            // In This example b is copy of `a`. When `b` changed, `a` remains unaffected becuat they
            // are independent copies.

            Point p1 = new Point { X = 10, Y = 20 };
            Point p2 = p1;      // Copy the value of p1 to p2

            Console.WriteLine($"Before change: p1 = ({p1.X}, {p1.Y}), p2 = ({p2.X}, {p2.Y})");

            p2.X = 30;  // Change the value of p2

            Console.WriteLine($"After change p2 = ({p1.X}, {p1.Y}), p2 = ({p2.X}, {p2.Y})");

            // Reference Type Example
            // Reference types include classes, arrays, delegates, and string. They hold a reference
            // to the actual data. When you assign one reference type variable to another, both
            // variables refer to the same object in memory.

            Console.WriteLine("\n------------------- Reference Type Example -----------------");
            Person person1 = new Person { Name = "Alice" };
            Person person2 = person1; // Copy the reference of person1 to person2

            Console.WriteLine($"Before change: person1.Name = {person1.Name}, person2.Name = {person2.Name}");

            person2.Name = "Bob"; // Change the value of person2

            Console.WriteLine($"After change: person1.Name = {person1.Name}, person2.Name = {person2.Name}");
        }

        struct Point
        {
            public int X;
            public int Y;
        }
        class Person
        {
            public string Name;
        }
    }
}
