using System;

namespace constructor_chaining
{
    // Constructor chaining in C# refers to the practice of having one
    // constructor call another constructor within the same class or
    // from a base class. This technique is useful for reducing code
    // duplication and ensuring that initialization logic is centralized
    // in one place.

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor with no parameters
        public Person() : this("Unknown", 0)
        {
            Console.WriteLine("Default constructor called.");
        }

        // Constructor with one parameter
        public Person(string name) : this(name, 0)
        {
            Console.WriteLine("Constructor with one parameter called.");
        }

        // Constructor with two parameters
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Constructor with two parameters called.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("Rovid");
            Person person3 = new Person("Kashyap", 30);
        }
    }
}
