using System;
using System.Runtime.InteropServices;

namespace datatypes_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datatypes are categorised into several types:

            /*

             1. VALUE TYPES
                a. Integral Types
                b. Floating-point Types
                c. Decimal Type
                d. Boolean Type
                e. Structs and Enumerations

             2. REFERENCE TYPES
                a. Class Types
                b. Interface Types
                c. Array Types
                d. Delegate Types
                e. String Type

             3. POINTER TYPES
                a. Pointers (unsafe context)

             4. SPECIAL TYPES
                a. Object Types
                b. Dynamic Type

            */

            #region Integral Types
            byte b = 255;                       // 8-bit unsigned integer
            sbyte sb = -128;                    // 8-bit signed integer
            short s = -32768;                   // 16-bit signed integer
            ushort us = 65535;                  // 16-bit unsigned integer
            int i = -2147483648;                // 32-bit signed integer
            uint ui = 4294967295;               // 32-bit unsigned integer
            long l = -9223372036854775808;      // 64-bit signed integer
            ulong ul = 18446744073709551615;    // 64-bit unsigned integer
            char c = 'A';                       // 16-bit Unicode character
            #endregion

            #region Floating Point
            float f = 3.14f;        // 32-bit single-precision floating point
            double d = 3.14;        // 64-bit double-precision floating point
            #endregion

            #region Decimal Type
            decimal dec = 3.14m;        // 32-bit precise decimal values
            #endregion

            #region Boolean Type
            bool flag = true;           // true or false
            #endregion
        }

        #region Structs and Enumerations
        struct Point
        {
            public int X;
            public int Y;
        }
        Point p = new Point { X = 1, Y = 2 };

        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        Days today = Days.Monday;
        #endregion

        #region Class Types
        class Person
        {
            public string Name;
            public int Age;
        }
        Person person = new Person { Name = "John", Age = 30 };
        #endregion

        #region Interface Types
        interface IGreet
        {
            void Greet();
        }
        class Greeter : IGreet
        {
            public void Greet()
            {
                Console.WriteLine("Hello!");
            }
        }
        #endregion

        #region Array Types
        int[] numbers = { 1, 2, 3, 4, 5 };
        #endregion

        #region Delegate Types
        delegate void Print(string message);
        Print printer = Console.WriteLine;
        //printer("Hello, World!");
        #endregion

        #region String Types
        string message = "Hello, World!";
        #endregion

        #region Object Type
        object obj = "Hello, Workd!";
        #endregion

        #region Dynamic Type
        dynamic dyn = 1;
        // dyn = "Hello, World!";
        #endregion

    }
}

