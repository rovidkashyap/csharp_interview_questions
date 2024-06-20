using System;

namespace types_of_classes
{
    // In C#, There are Four Types of Classes available:
    // 1. STATIC CLASS
    // 2. ABSTRACT CLASS
    // 3. SEALED CLASS
    // 4. PARTIAL CLASS

    // 1. STATIC CLASS - It cannot instantiated and are used to create method and properties that belongs to the class itself
    // rather than to any specific object

    #region STATIC CLASS
    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    #endregion

    // ABSTACT CLASS - It cannot instantiate directly and are intended to be inherited by other classes. They contain
    // abstract methods that must be implemented by derived class.

    #region ABSTRACT CLASS
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    #endregion

    // SEALED CLASS - It cannot be inherited. They are useful when you want to restrict the extensibility of a class and
    // ensure that it cannot be used as a base class.

    #region SEALED CLASS
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        // Private constructor to prevent instantitated
        public Logger()
        {
        }

        // Public property to provide access to single instance
        public static Logger Instance
        {
            get { return _instance; }
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log: {DateTime.Now}: {message}");
        }
    }
    #endregion

    // PARTIAL CLASS - They allow you to split the defination of class into multiple files. This is useful for manaaging 
    // large classes or for seperating auto-generated code from manually written code.

    #region PARTIAL CLASS
    public partial class Car
    {
        public string Make { get; set; }
    }
    
    public partial class Car
    {
        public string Model { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}");
        }
    } 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            // Acessing Static Class
            int result = MathHelper.Add(55, 45);
            Console.WriteLine(result);

            // Accessing Sealed Class
            Logger logger = Logger.Instance;
            logger.Log("\nThis is Log Message");

            // Accessing Partial Class
            Car myCar = new Car();
            myCar.Make = "2024";
            myCar.Model = "Bronze";
            myCar.DisplayInfo();
        }
    }
}
