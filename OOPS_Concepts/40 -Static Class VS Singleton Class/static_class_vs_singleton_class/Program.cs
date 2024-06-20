using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace static_class_vs_singleton_class
{
    // Static classes and Singleton classes are both design patterns used in C# to achieve different objectives related to object creation and behavior. 

    // Static class cannot instantiated. All members (method, properties, fields) of static class ust be static.
    // Accessing the Static Class by its class name.

    #region STATIC CLASS
    public static class MathUtility
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
    #endregion

    // SINGLETON CLASS
    // A Singleton class ensures that only one instance of the class exists throughout the application lifecycle.
    // Uses a private constructor to prevent direct instantiation and provides a static method or property to access the single instance.

    #region SINGLETON CLASS
    public sealed class ConfigurationManager
    {
        private static readonly ConfigurationManager instance = new ConfigurationManager();

        // Private constructor to prevent instantiatiom
        private ConfigurationManager() { }

        // Public static property to access the single instance
        public static ConfigurationManager Instance
        {
            get { return instance; }
        }
        public string GetConnectionString()
        {
            // Example Method
            return "Data Source=ServerName; Initial Catalog=DatabaseName; Integrated Security=True;";
        }
    }

    
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            int result = MathUtility.Add(5, 3);
            Console.WriteLine(result);

            // Usage:
            string connectionString = ConfigurationManager.Instance.GetConnectionString();
        }
    }
}
