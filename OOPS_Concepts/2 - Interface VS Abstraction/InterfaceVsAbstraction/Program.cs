using System;

namespace InterfaceVsAbstraction
{
    // Abstract Class :
    // 1. Cannot Instantiated Directly. It must be inherited by another class.
    // 2. Contains have both abstract methods (without implementation) and concrete method (with implementation)
    // 3. Class can inherit only one abstract class due to C# single inheritance model.
    // 4. Can define access modifiers for its methods and properties (public, protected, etc.)

    #region ABSTRACT CLASS
    public abstract class Animal
    {
        // Abstract Method (With No Implementation)
        public abstract void MakeSound();

        // Non-Abstract Method (With Implementation)
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    public class Dog : Animal       // Non-Abstract Class Inherit Abstract Class
    {
        public override void MakeSound()    // Override Abstract Method
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal        // Non-Abstract Class Inherit Abstract Class
    {
        public override void MakeSound()    // Override Abstract Method
        {
            Console.WriteLine("Meow");
        }
    }
    #endregion

    // INTERFACE :
    // 1. Cannot be instantiated directly. It must be implement by class.
    // 2. cannot have any method implementations (before c# 8.0).All methods are abstract by default.
    // 3. class can implement multiple interfaces, allowing for a form to multiple inheritance.
    // 4. Methods and properties are implicitly public and cannot have access modifiers.

    #region INTERFACES
    public interface IAnimal
    {
        // Method Signatures (No Implementation)
        void MakeSound();
        void Sleep();
    }

    public class Goat: IAnimal
    {
        // Providing implementation for the interface methods
        public void MakeSound()
        {
            Console.WriteLine("Mmmhhh");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    public class Buffalo : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Muuaaah");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- ABSTACT CLASS EXAMPLE -----------------");
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.MakeSound();        // Outputs: Bark
            dog.Sleep();            // Outputs: Sleeping...

            cat.MakeSound();        // Outputs: Meow
            cat.Sleep();            // Outputs: Sleeping...

            Console.WriteLine("-------------- INTERFACE EXAMPLE ----------------------");
            Goat goat = new Goat();
            Buffalo buffalo = new Buffalo();

            goat.MakeSound();       // Outputs: Mmmhhh
            goat.Sleep();           // Outputs: Sleeping...

            buffalo.MakeSound();    // Outputs: Muuaaah
            buffalo.Sleep();        // Outputs: Sleeping...
        }
    }
}
