using System;

namespace Struct_and_Class
{
    // In C#,both 'Struct' and 'Class' are used to define custom data types, but they are differ in the
    // term of Memory allocation, Inheritance and usage.

    // Class are allocated on the heap and reference to object is stored in the variable
    // Struct are allocated on the stack, they are value types and are contained directly in variable

    // Classes are reference types, when you assign an object to another, both references point to same
    // memory location.
    // Struct are value types, when you assign a struct to another, a copy of the data is made.

    // Classes supports Inheritance, one class inherit from another class.
    // Struct does not support inheritance from another struct or class.

    // Class can have default constructor and destructor.
    // Struct cannot have default constructor (a parameterless constructor), it can have parameterized
    // constructor

    // Class suitable for complex data structure with significant logic, large size and where inheritance
    // is needed.
    // Sturct suitable for small data structure that contains primarily data and where the overhead of
    // heap allocation is unnecessary

    #region CLASS EXAMPLE
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    #endregion

    #region STRUCT EXAMPLE
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------- CLASS EXAMPLE -----------------");
            Person person1 = new Person("Rovid", 33);
            Person person2 = person1;       // Reference Copy

            person2.Name = "Kashyap";

            person1.Display();              // Output: Name: Kashyap, Age: 33
            person2.Display();              // Output: Name: Kashyap, Age: 33

            Console.WriteLine("\n------------------ STRUCT EXAMPLE -------------------");
            Point point1 = new Point(10, 20);
            Point point2 = point1;          // Value Copy

            point2.X = 30;

            point1.Display();               // Output: X: 10, Y: 20
            point2.Display();               // Output: X: 30, Y: 20
        }
    }
}
