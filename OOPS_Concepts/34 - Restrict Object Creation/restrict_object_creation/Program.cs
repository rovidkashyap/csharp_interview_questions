using System;
using System.Security.Policy;

namespace restrict_object_creation
{
    // Yes, It is possible to restrict object creation in c# using various techniques such as 
    // private constructor, static factory and singleton pattern.

    // We can make class constructor private to prevent direct instantiation of objects from outside
    // the class.

    #region PRIVATE CONSTRUCTOR
    public class UtilityClass
    {
        // Private Constructor to prevent object instantiation
        private UtilityClass()
        {
            // Constrcutor Logis (if any)
        }
        // Static method that can be accessed without creating an instance
        public static void DoSomething()
        {
            Console.WriteLine("UtilityClass - Doing something...");
        }
    }
    #endregion

    // Static method is method in a class that returns an instance of the class.
    // By controlling the creation logic within this method, you can restrict how objects are instantiated.
    
    #region STATIC FACTORY METHOD
    public class Car
    {
        private string brand;
        // private constructor
        private Car(string brand)
        {
            this.brand = brand;
        }

        // Static factory method to create instances of Car
        public static Car CreateCar(string brand)
        {
            // Additional logic can be applied here before creating the instance
            return new Car(brand);
        }
        public void DisplayBrand()
        {
            Console.WriteLine($"Brand: {brand}");
        }
    }
    #endregion

    // Singelton Pattern restricts the instantiation of a class to one single instance and provides global point
    // of access to that instance

    #region SINGLETON PATTERN
    public sealed class ConfigurationManager
    {
        private static readonly ConfigurationManager instance = new ConfigurationManager();

        // Private constructor to prevent instantiation
        private ConfigurationManager()
        {
            // Initialization logic (if any)
        }

        // Public property to provide access to the single instance
        public static ConfigurationManager Instance
        {
            get { return instance; }
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine("Displaying configuration...");
        }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            // Attempting to create an instance will result in a compile-time error
            // UtilityClass utility = new UtilityClass(); // Error: 'UtilityClass' constructor is inaccessible

            // Accessing the static method directly
            UtilityClass.DoSomething();

            // Using Static factory method to create an instance
            Car myCar = Car.CreateCar("Toyota");
            myCar.DisplayBrand();

            // Attempting to use private constructor directly will result in compile-time error
            //Car anotherCar = new Car("Honda");

            // Accessing the single Instance of the ConfigurationManager
            ConfigurationManager configManager = ConfigurationManager.Instance;
            configManager.DisplayConfiguration();

            // Attempting to create another instance will return the same instance
            ConfigurationManager anotherConfigManager = ConfigurationManager.Instance;
            anotherConfigManager.DisplayConfiguration();
        }
    }
}
