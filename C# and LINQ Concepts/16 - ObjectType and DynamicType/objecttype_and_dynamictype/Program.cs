namespace objecttype_and_dynamictype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, both object type variables and dynamic type variables provide flexibility in
            // handling different types of data, but they differ significantly in how they are
            // treated by the compiler and at runtime.

            // OBJECT-TYPE VARIABLES (`object`) :

            // 1. Type-checked at compile-time. Required explicit cating to access members.
            // 2. May involve boxing/unboxing for value types, impacting performance.

            object obj = 42;    // Boxing int to object
            obj = "hello";      // Assigning a string

            int number = (int)obj;  // Unboxing object to int

            // DYNAMIC_TYPE VARIABLES (`dynamic`) :

            // 1. Type-checked at runtime. Allows member access without casting.
            // 2. Avoid boxing.unboxing but may incur overhead due to runtime type-resolution.

            dynamic dyn = 42;
            dyn = "hello";

            dyn += 10;  // OK: treated as int
            dyn = "hello";
            dyn += " world";    // OK: treated as string
        }
    }
}
