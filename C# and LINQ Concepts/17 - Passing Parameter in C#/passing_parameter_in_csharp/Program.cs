using System;

namespace passing_parameter_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, you can pass parameters to a method in several ways, depending on your requirements
            // for passing data and modifying values.

            // 1. Value Parameters (Pass by Value). (By Default in C#)
            // 2. Reference Parameters (Pass by Reference).
            // 3. Output Parameters.
            // 4. Params Parameters.
            // 5. Named Parameters.

            #region Pass By Value
            void Method(int x)
            {
                Console.WriteLine("------------------------ Pass By Value --------------------\n");
                // x is passed by value
                x = x * 2;  // Changes only affect the local copy
                Console.WriteLine($"x is: {x}");
            }
            #endregion

            // Calling Pass by Value Method
            Method(5);

            #region Pass By Reference
            // Using `ref` keyword allows a method to modify the value of the parameter directly.
            // The method receives a reference to the original variable.

            void Method_2(ref int x)
            {
                Console.WriteLine("\n--------------------- Pass By Reference ---------------------\n");
                // x is passed by reference
                x = x * 2;  // Changes affect the original variable

                Console.WriteLine($"x is: {x}");
            }
            #endregion

            // Calling method with ref parameter
            int number = 10;
            Method_2(ref number);

            #region Output Parameters
            Console.WriteLine("\n--------------------- Output Parameters ---------------------\n");
            // Using `out` keyword indicates that a parameter is initialized by method and return value.
            void Method_3(out int result)
            {
                // out parameter must be assigned inside the method
                result = 42;
            }
            #endregion

            // Calling method with out parameter
            int number_1;
            Method_3(out number_1);

            #region Params Parameters
            void Method_4(params int[] numbers)
            {
                Console.WriteLine("\n------------------- Params Parameters ---------------------\n");
                // numbers is treated as an array of integers
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
            #endregion

            // Calling method with variable number of parameters
            Method_4(1, 2, 3);
            Method_4(4, 5);

            #region Named Parameters
            void Method_5(int x, string message)
            {
                Console.WriteLine("\n----------------- Named Parameters ------------------\n");
                // Method implementation
            }
            #endregion

            // Calling method with named parameters
            Method_5(message: "Hello", x: 42);

            /*
             
                1. Value Parameters: Default behavior, passes a copy of the value.

                2. Reference Parameters: Modifies the original value through a reference.

                3. Output Parameters: Returns a value through a parameter.

                4. Params Parameters: Handles a variable number of arguments as an array.

                5. Named Parameters: Improves readability by specifying parameters by name.
            
            */
        }
    }
}
