namespace boxing_and_unboxing_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
                Boxing and unboxing in C# refer to the process of converting a value type to/from 
                the object type (System.Object). This conversion is necessary because value types 
                (such as int, double, bool, etc.) are stored on the stack, while reference types 
                (like classes) are stored on the heap.

            */

            // BOXING:
            // Process of Converting a Value Type to the object type (`System.Object`)

            int i = 42;
            object obj = i; // Boxing: int is converted to object

            // Allocates memory on the heap to store the boxed value and copies the value from the
            // stack to the heap.

            // UNBOXING:
            // Unboxing is the process of converting an object (`System.Object`) back to a value type.

            object obj1 = 42;
            int j = (int)obj1;  // Unboxing: object is converted back to int

            // Retrieves the value from the heap and copies it to the stack.
        }
    }
}
