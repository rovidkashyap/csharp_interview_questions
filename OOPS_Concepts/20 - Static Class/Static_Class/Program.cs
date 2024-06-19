using System;

namespace Static_Class
{
    // STATIC CLASS -

    // 1. Static class is a special type of class that cannot be instantiated and can only contains static members.
    // (like fields, methods, properties, events and nested types).
    // 2. Static class does not instantiated, they do not allocate memory on the heap for objects.
    // 3. Static class are stored in a special area of memory known as the 'high frequency heap'.

    public class Program
    {
        static void Main(string[] args)
        {
            // Access the static Class and methods without creating object
            double result = MathHelper.CalculateCircleArea(154.5);
            Console.WriteLine($"Area of Circle: {result}");
        }
    }

    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
