using System;

namespace Constant_and_Readonly
{
    //CONST -

    //1. The Value of 'const' field is set at compile-time and cannot be change afterward.
    //2. 'const' field are implicitly static, so they belong to type itself.
    //3. No Instance of class is needed to access a 'const' field.

    // READONLY - 

    //1. Value can be set at Runtime but only once, either in declaration or in constructor.
    //2. Can be either instance level or static.
    //3. If Not explicitly marked as static, each instance of class can have its own 'readonly' field.

    public class Program
    {
        public const int MyConstant = 42;       // Const Define with value
        public readonly int MyReadOnly;         // Readonly defined without value

        public Program(int initialValue)
        {
            MyReadOnly = initialValue;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("----------------- CONST --------------------");
            Console.WriteLine($"The Value of MyConstant is {MyConstant}");
            // MyConstant = 50; // This will cause error a compile-time.

            Program program1 = new Program(10);
            Program program2 = new Program(20);

            Console.WriteLine("\n---------------- READONLY ----------------");
            Console.WriteLine($"The value of program1.MyReadOnly is {program1.MyReadOnly}");
            Console.WriteLine($"The value of program2.MyReadOnly is {program2.MyReadOnly}");
        }
    }
}
