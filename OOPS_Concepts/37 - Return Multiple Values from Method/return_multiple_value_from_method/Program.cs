using System;

namespace return_multiple_value_from_method
{
    // In C#, A Method can return only one value at a time.
    // However, there are several techniques through which you can return multiple values.

    // 1. RETURNING TUPLE
    // 2. USING `Out` PARAMETERS
    // 3. RETURNING A CUSTOM CLASS OR STRUCT

    // Since C# 7.0, you can use tuples to return multiple values from a method.

    public class Program
    {
        static void Main(string[] args)
        {
            //Return Using Tuple
            Console.WriteLine("-------------- Return Using Tuple -----------------");
            (int sum, int difference) = CalculateSumAndDifference(10, 5);
            Console.WriteLine($"Sum: {sum}, Difference: {difference}");

            // Return Using Out Parameter
            Console.WriteLine("\n-------------- Return Using Out Parameter ---------------");
            int sum1, difference1;
            CalculateSumAndDifference1(10, 5, out sum1, out difference1);
            Console.WriteLine($"Sum: {sum}, Difference: {difference}");

            // Return Using Custom Class OR Struct
            Console.WriteLine("\n-------------- RETURN USING CUSTOM CLASS OR STRUCT ---------------");
            CalculationResult result = CalculateSumAndDifference2(10, 5);
            Console.WriteLine($"Sum: {result.Sum}, Difference: {result.Difference}");
        }

        #region RETURN TUPLE METHOD
        public static (int, int) CalculateSumAndDifference(int a, int b)
        {
            int sum = a + b;
            int difference = a - b;
            return (sum, difference);
        }
        #endregion

        #region OUT PARAMETERS
        public static void CalculateSumAndDifference1(int a, int b, out int sum, out int difference)
        {
            sum = a + b;
            difference = a - b;
        }
        #endregion

        #region CUSTOM CLASS OR STRUCT
        public static CalculationResult CalculateSumAndDifference2(int a, int b)
        {
            int sum = a + b;
            int difference = a - b;
            return new CalculationResult { Sum = sum, Difference = difference };
        }
        public class CalculationResult
        {
            public int Sum { get; set; }
            public int Difference { get; set; }
        }
        #endregion
    }
}
