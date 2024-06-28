using System;
using System.Security.Cryptography.X509Certificates;

namespace inherit_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yes, in C#, a class can inherit from another class. This is a fundamental concept in
            // object-oriented programming known as "inheritance." When a class inherits from
            // another class, it inherits all the public and protected members (fields, methods,
            // properties, events) of the base class. The derived class can also add its own members
            // and can override virtual members of the base class.

            Dog myDog = new Dog
            {
                Name = "Buddy",
                Age = 3,
                Breed = "Golden Retriever"
            };

            myDog.Eat();        // Inherited from Animal
            myDog.Sleep();      // Inherited from Animal
            myDog.Bark();       // Defined in Dog
            myDog.Speak();      // Overriden in Dog
        }

        #region Base Class
        public class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating.");
            }

            public void Sleep()
            {
                Console.WriteLine($"{Name} is sleeping.");
            }

            public virtual void Speak()
            {
                Console.WriteLine($"{Name} is making a sound.");
            }
        }
        #endregion

        #region Derived Class
        public class Dog : Animal
        {
            public string Breed { get; set; }
            public void Bark()
            {
                Console.WriteLine($"{Name} is barking.");
            }

            // Override the Speak method
            public override void Speak()
            {
                Console.WriteLine($"{Name} is barking.");
            }
        }
        #endregion

    }
}
