using System;
using System.Security.Policy;

namespace oops_features
{
    // ENCAPSULATION - Buldles Data and methods within classes and restricts access to the internal state.
    // INHERITANCE - Allow a class to inherit properties and methods from another class.
    // POLYMORPHISM - Enables treating objects of different classes through a common interface.
    // ABSTRACTION - Hides complex implementations details, showing only the necessary features.

    #region ENCAPSULATION
    public class Car
    {
        // Private Fields
        private int speed;
        private int gear;
        private int fuelLevel;

        // Public properties for controlled access
        public int Speed
        {
            get { return speed; }
            private set { speed = value; }
        }

        public int Gear
        {
            get { return gear; }
            private set { gear = value; }
        }

        public int FuelLevel
        {
            get { return fuelLevel; }
            private set { fuelLevel = value; }
        }

        //Constructor
        public Car(int speed = 0, int gear = 1, int fuelLevel = 100)
        {
            this.gear = gear;
            this.speed = speed;
            this.fuelLevel = fuelLevel;
        }

        //Methods to manipulate the fields
        public void Accelerate(int increment) => speed += increment;
        public void Brake(int decrement) => speed -= decrement;
        public void Refuel(int amount) => fuelLevel += amount;

    }
    #endregion

    #region INHERITANCE
    public class SportCar : Car
    {
        public bool TurboMode { get; private set; }
        public SportCar(int speed = 0, int gear = 1, int fuelLevel = 100)
            : base(speed, gear, fuelLevel)
        {
            TurboMode = false;
        }

        public void ActivateTurbo()
        {
            TurboMode = true;
            Accelerate(50);
        }

        public void DeactivateTurbo()
        {
            TurboMode = false;
            Brake(50);
        }
    }
    #endregion

    #region POLYMORPHISM
    public abstract class Animal
    {
        public abstract void Speak();
    }

    // Create Cat Class with inherit Animal class and override Speak method
    public class Cat: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
    // Create Dog class with inherit Animal class and override Speak method
    public class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Bark");
        }
    }
    #endregion

    #region ABSTRACTION
    public abstract class Shape     // Create Abstract Class
    {
        public abstract double Area();  // Create Abstract Method
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }

    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- EXAMPLE OF ENCAPSULATION ----------------");
            Car myCar = new Car();
            myCar.Accelerate(10);
            Console.WriteLine("Speed after accelerating: " + myCar.Speed);

            myCar.Brake(5);
            Console.WriteLine("Speed after braking: " + myCar.Speed);

            myCar.Refuel(20);
            Console.WriteLine("Fuel Level after refueling: " + myCar.FuelLevel);

            Console.WriteLine("\n----------------- EXAMPLE OF INHERITANCE -----------------");
            SportCar mySportCar = new SportCar();
            mySportCar.ActivateTurbo();
            Console.WriteLine("Speed after Activating turbo: " + mySportCar.Speed);

            mySportCar.DeactivateTurbo();
            Console.WriteLine("Speed after Deactivating turbo: " + mySportCar.Speed);

            Console.WriteLine("\n----------------- EXAMPLE OF POLYMORPHISM ---------------------");
            Animal myCat = new Cat();   // Create Object of Cat Class
            Animal myDog = new Dog();   // Create Object of Dog Class

            myCat.Speak();  // Output: Meow
            myDog.Speak();  // Output: Bark

            Console.WriteLine("\n----------------- EXAMPLE OF ABSTRATION ----------------------");
            Shape[] shapes = { new Rectangle(10, 20), new Circle(5) };

            foreach (var item in shapes)
            {
                Console.WriteLine("Area: " + item.Area());
            }
        }
    }
}
