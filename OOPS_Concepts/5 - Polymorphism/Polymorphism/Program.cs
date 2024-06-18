using System;

namespace Polymorphism
{
    // Compile-Time Polymorphism or Method Overloading allows a class to have multiple methods with the same name but different parameters.
    // This Resolved at compile-time.
    // Overloading - Same Name, different signatures.

    #region COMPILE-TIME POLYMORPHISM (METHOD OVERLOADING)
    public class MathOperations
    {
        // Overloaded methods with different parameter types
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    #endregion

    // Runtime Polymorphism or Method Overriding allows a subclass to provide a specific implementation of a method that is already defined in its superclass.
    // This Resolved at Run-time.
    // Overriding - Same Method name and signature in base and derived classes.

    #region RUNTIME POLYMORPHISM (METHOD OVERRIDING)
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a Sound.");
        }
    }
    public class Dog: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    public class Cat: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();
            Console.WriteLine(math.Add(2, 3));              // Outputs: 5
            Console.WriteLine(math.Add(2.5, 3.5));          // Outputs: 6.0
            Console.WriteLine(math.Add(1, 2, 3));           // Outputs: 6

            Console.WriteLine();

            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.MakeSound();                           // Outputs: Animal makes a sound
            myDog.MakeSound();                              // Outputs: Bark
            myCat.MakeSound();                              // Outputs: Meow
        }
    }
}
