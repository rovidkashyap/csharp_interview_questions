using System;

namespace this_and_base_keyword
{
    // `this` Keyword refers to the current instance of class.
    // It is often used to clarify that a method or property refers to a member of the current instance, especially when
    // there is naming conflict with parameters or local variables
    // `this` keyword is used to access instance variables, properties and methods.
    // `this` keyword is used to call on constructor from another constructor within the same class.
    // `this` keyord is used to pass the current instance as a parameter to other methods.

    #region `this` KEYWORD
    public class Person
    {
        public string name;
        public int age;

        // Constructor
        public Person(string name, int age)
        {
            // Using 'this' to differentiate between the class member and constructor parameters
            this.name = name;
            this.age = age;
        }

        // Methods to display personal details
        public void DisplayInfo()
        {
            // Using `this` to call another method of the same instance
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }

        // Method that returns the current instance using `this`
        public Person GetPersonInstance()
        {
            return this;
        }
    }
    #endregion

    // `base` Keyword is used to access members of the base class from within a derived class.
    // It is particulary useful when you need to call a method or access a property that has been overriden in 
    // derived class, or to call a base class constructor.
    // It is used to call a base class constructor from the derived class constructor.

    #region `base` KEYWORD
    public class Animal
    {
        public string Name { get; set; }

        // Base class Constructor
        public Animal(string name)
        {
            Name = name;
        }

        // Base class Method
        public void DisplayInfo()
        {
            Console.WriteLine($"Animal: {Name}");
        }
    }
    public class Dog : Animal
    {
        public string Breed { get; set; }

        // Derived class constructor that calls the base class constructor
        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        // Overriding the base class method
        public new void DisplayInfo()
        {
            // Using the `base` to call the base class method
            base.DisplayInfo();
            Console.WriteLine($"Breed: {Breed}");
        }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            // Accessing `this` Keyword Classes

            Person person = new Person("Rovid", 32);
            person.DisplayInfo();

            Person samePerson = person.GetPersonInstance();
            samePerson.DisplayInfo();

            // Accessing `base` Keyword Class
            Dog dog = new Dog("Buddy", "Golden Retriever");
            dog.DisplayInfo();
        }
    }
}
