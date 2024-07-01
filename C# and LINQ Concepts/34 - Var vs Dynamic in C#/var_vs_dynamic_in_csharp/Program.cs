using System;
using System.Collections.Generic;
using System.Dynamic;

namespace var_vs_dynamic_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, both var and dynamic are used to declare variables, but they serve different
            // purposes and have distinct behaviors.

            // `var` - The Compiler detects the variable type at compile-time.
            //       - Type is determined at compile-time and variable must be assign a value at time
            //          of declaration.
            //       - It offers better performance due to compile-time type checking.
            //       - Intellisense support is available at IDE's like Visual Studio.

            var number = 10;                // int
            var text = "Hello, World";      // string
            var list = new List<int>;       // List<int>

            // `dynamic` - The type is determined at runtime rather than compile-time.
            //           - Limited intellisense support since the type is not known until runtime.

            dynamic mynumber = 10;
            dynamic mytext = "Hello, World";
            dynamic obj = new ExpandoObject();

            // Changing type at runtime
            mynumber = "Now I'm at runtime";
            mytext = 12345;     // Now it's an int

            // Accessing property dynamically
            obj.NewProperty = "New Value";
            Console.WriteLine(obj.NewProperty);
        }
    }
}
