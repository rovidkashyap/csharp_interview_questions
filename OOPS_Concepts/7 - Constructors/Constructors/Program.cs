using System;
using System.Runtime.Remoting.Messaging;

namespace Constructors
{
    // Constructors are special methods that are called when an instance of class is created.. It is used to initialize the state of an object, having same name as class and
    // does not have return type, not evem 'void'.

    // IN C# THERE ARE 5 TYPES OF CONSTRUCTORS :-

    // 1. DEFAULT CONSTRUCTOR
    // 2. PARAMETERIZED CONSTRCUTOR
    // 3. COPY CONSTRUCTOR
    // 4. STATIC CONSTRUCTOR
    // 5. PRIVATE CONSTRUCTOR

    // DEFAULT CONSTRUCTOR - It is Default Constructor of class that takes no parameters. If no Constructor defined in class, C# automatically provides default constructor automatically.
    // PARAMETERIZED CONSTRUCTOR - It is Constructor that takes one or more Parameters. It allows you to initialize the objects with specific values at time of creation.
    // COPY CONSTRUCTOR - It Initialize the object using another object of the same class. This is not provided default in C#, but you can define manually.
    // STATIC CONSTRUCTOR - It is used to initialize static members of class. It is called only once, when class is accessed for the first time. It does not have parameters.
    // PRIVATE CONSTRUCTOR - It is used to restrict the Instantiation of a class from outside the class. It is typically used in Singleton Design Pattern or Static class.

    #region CONSTRUCTORS
    public class Car
    {
        public string Make;
        public string Model;
        public static int TotalCars;

        // DEFAULT CONSTRUCTOR
        public Car()
        {
            Make = "Unknown";
            Model = "Unknown";
        }

        // PARAMETERIZED CONSTRUCTOR
        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        // COPY CONSTRUCTOR
        public Car(Car car)
        {
            Make = car.Make;
            Model = car.Model;
        }

        // STATIC CONSTRUCTOR
        static Car()
        {
            TotalCars = 100;
        }
    }

    #endregion

    #region PRIVATE CONSTRUCTORS
    public class Singleton
    {
        public static Singleton instance = null;
        // Private Constructor
        private Singleton() { }

        // Public Method to get the instance of the class
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton Instance");
        }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- DEFAULT CONSTRUCTOR ------------");
            Car myCar = new Car();
            Console.WriteLine($"Make: {myCar.Make}, Model: {myCar.Model}");

            Console.WriteLine("\n---------- PARAMETERIZED CONSTRUCTOR ------------");
            Car myCar1 = new Car("Toyota", "Corolla");
            Console.WriteLine($"Make: {myCar1.Make}, Model: {myCar.Model}");

            Console.WriteLine("\n---------- COPY CONSTRUCTOR ------------");
            Car myCar2 = new Car("Hyundai", "Creta");
            Car myCar3 = new Car(myCar2);
            Console.WriteLine($"Car2 Make: {myCar2.Make}, Model: {myCar2.Model}");
            Console.WriteLine($"Car3 Make: {myCar3.Make}, Model: {myCar3.Model}");

            Console.WriteLine("\n---------- Static Constructor -------------");
            Car myCar4 = new Car("Tata", "Punch");
            Car myCar5 = new Car("Tata", "Nexon");
            Console.WriteLine($"Total Cars: {Car.TotalCars}");

            Console.WriteLine("\n---------- PRIVATE CONSTRUCTOR ------------");
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            singleton1.ShowMessage();

            // Check if both instances are the same
            Console.WriteLine(object.ReferenceEquals(singleton1, singleton2));      // Outputs: True
        }
    }
}
