using System;

namespace Inheritance
{
    // TYPES OF INHERITANCE ----------------
    // SINGLE INHERITANCE - A CLASS INHERIT FROM ONE BASE CLASS
    // MULTILEVEL INHERITANCE - A CLASS DERIVED FROM ANOTHER DERIVED CLASS
    // HIERARCHICAL INHERITANCE - MULTIPLE CLASSES ARE DERIVED FROM A SINGLE BASE CLASS
    // MULTIPLE INHERITANCE (THROUGH INTERFACE) - C# DOES NOT SUPPORT MULTIPLE INHERITANCE OF CLASSES
                                                // DIRECTLY, BUT IT CAN BE ACHIEVED THROUGH INTERFACES.
    // HYBRID INHERITANCE - IT IS COMBNATION OF TWO OR MORE TYPES OF INHERITANCE. IN C# YOU CAN ACHIEVE
                            // THIS THROUGH A COMBINATION OF CLASS AND INTERFACE INHERITANCE

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    class Dog : Animal           // Single Inheritance - Inherit from one Base Class
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    class BullDog : Dog          // Multilevel Inheritance - Inherit from another derived class Dog which is already a derived class.
    {
        public void Snore()
        {
            Console.WriteLine("Snoring...");
        }
    }
    class Cat: Animal           // HIERARCHICAL INHERITANCE - MULTIPLE DERIVED CLASS FROM ONE BASE CLASS
    {
        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
    }

    interface IAnimal { void Eat(); }  
    interface IPet { void Play(); }

    class Dove : IAnimal, IPet          // MULTIPLE INHERITANCE (THROUGH INTERFACES)
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Play()
        {
            Console.WriteLine("Playing...");
        }
    }

    class Moose : Animal, IPet      // Hybrid Inheritance
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
        public void Play()
        {
            Console.WriteLine("Playing...");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- SINGLE INHERITANCE -----------");
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();

            Console.WriteLine("\n-------------- MULTILEVEL INHERITANCE --------------");
            BullDog myBullDog = new BullDog();
            myBullDog.Eat();
            myBullDog.Bark();
            myBullDog.Snore();

            Console.WriteLine("\n-------------- HIERARCHICAL INHERITANCE --------------");
            Dog myDog1 = new Dog();
            myDog1.Eat();   // Inhertied from Animal
            myDog1.Bark();  // Defined in Dog

            Cat myCat = new Cat();
            myCat.Eat();    // Inherit from Animal
            myCat.Meow();   // Defined in Cat

            Console.WriteLine("\n-------- MULTIPLE INHERITANCE (THROUGH INTERFACE) ---------");
            Dove myDove = new Dove();
            myDove.Eat();       // Implemented from IAnimal
            myDove.Play();      // Implemented from IPet

            Console.WriteLine("\n--------------- HYBRID INHERITANCE ------------------");
            Moose myMoose = new Moose();
            myMoose.Eat();      // Inherited from Animal
            myMoose.Bark();     // Defined in Moose
            myMoose.Play();     // Implemented from IPet
        }
    }
}
