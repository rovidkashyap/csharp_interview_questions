using System;

namespace nullable_type_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, the `Nullable<T>` type also known as the nullable type or nullable value type,
            // allows you to assign null to value types like `int`, `double`, `bool`, etc. which 
            // normally cannot accept null values.

            // This is useful when you need to represent a value type that might not have a value.

            // Key Points:

            // 1. Value Types and Nullability: Normally, value types cannot be assigned null. For example,
            // `int` cannot hold a null value. `Nullable<T>` allows value types to be assigned null.

            // 2. Syntax: The syntax for using `Nullable<T>` is `Nullable<T>` or `T?`, where `T` is the
            // underlying value type.

            // int? nullableInt = null;
            // double? nullableDouble = 3.14;
            // bool? nullableBool = true;

            int? nullableInt = null;
            double? nullableDouble = 3.14;

            if (nullableInt.HasValue)
            {
                Console.WriteLine($"Nullable int value: {nullableInt.Value}");
            }
            else
            {
                Console.WriteLine("Nullable int is null");
            }

            Console.WriteLine($"Nullable double value: {nullableDouble}");
        }
    }
}
