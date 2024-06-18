using System;

namespace AbstractClassAndMethods
{
    // Abstract Class Provide template for other classes, can have both abstract and concrete methods, and cannot instantiated directly.
    // Abstract Methods is a method declared in the abstract class without implementation, and derived class must override and provide an implementation for it.

    public abstract class Vehicle
    {
        // Abstract Method (No Implementation)
        public abstract void StartEngine();

        // Non-Abstract Method or Concrete Method(With Implementation)
        public void StopEngine()
        {
            Console.WriteLine("Engine Stopped.");
        }

        // Non-Abstract Method or Concrete Method with Implementation
        public void Fuel()
        {
            Console.WriteLine("Refueling...");
        }
    }

    public class Car: Vehicle
    {
        // Providing implementation for the abstract method
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine Started.");
        }
    }
    public class Motorcycle: Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle Engine Started.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Car();
            myCar.StartEngine();                // Outputs: Car Engine Started.
            myCar.Fuel();                       // Outputs: Refueling...
            myCar.StopEngine();                 // Outputs: Engine Stopped.

            Console.WriteLine("");              // Insert Line Break

            Vehicle myMotorcycle = new Motorcycle();
            myMotorcycle.StartEngine();         // Outputs: Motorcycle Engine Started.
            myMotorcycle.Fuel();                // Outputs: Refueling...
            myMotorcycle.StopEngine();          // Outputs: Engine Stopped.
        }
    }
}
