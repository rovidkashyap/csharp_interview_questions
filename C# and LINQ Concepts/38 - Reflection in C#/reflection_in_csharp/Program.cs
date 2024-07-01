using System;
using System.Reflection;

namespace reflection_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reflection in C# is a powerful feature that allows you to inspect and manipulate the
            // metadata of types at runtime. This includes examining types, methods, properties,
            // fields, and more.

            // Get the type information
            Type type = typeof(MyClass);

            // Create an instance using the parameterless constructor
            object obj = Activator.CreateInstance(type);

            // Set the property value
            PropertyInfo nameProperty = type.GetProperty("Name");
            nameProperty.SetValue(obj, "John Doe");

            // Get and invoke a public method
            MethodInfo printNameMethod = type.GetMethod("PrintName");
            printNameMethod.Invoke(obj, null);

            // Get and invoke a private method
            MethodInfo setAgeMethod = type.GetMethod("SetAge", BindingFlags.NonPublic | BindingFlags.Instance);
            setAgeMethod.Invoke(obj, new object[] { 30 });

            // Get the value of a private field using a public method
            MethodInfo getAgeMethod = type.GetMethod("GetAge");
            int age = (int)getAgeMethod.Invoke(obj, null);
            Console.WriteLine($"Age: {age}");

            // List all methods
            Console.WriteLine("\nMethods:");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"{method.Name} (IsPublic: {method.IsPublic}, IsPrivate: {method.IsPrivate})");
            }

            // List all properties
            Console.WriteLine("\nProperties:");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.Name}, Type: {property.PropertyType}");
            }

            // List all fields
            Console.WriteLine("\nFields:");
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"{field.Name}, Type: {field.FieldType}, IsPublic: {field.IsPublic}, IsPrivate: {field.IsPrivate}");
            }
        }
    }

    public class MyClass
    {
        public string Name { get; set; }
        private int age;

        public MyClass() { }

        public MyClass(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public void PrintName()
        {
            Console.WriteLine($"Name: {Name}");
        }

        private void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
