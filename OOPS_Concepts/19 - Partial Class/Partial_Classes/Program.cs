using System;

namespace Partial_Classes
{
    // 1. Partial Class in C# provide felxibility in organizing and managing large class definitions.
    // 2. Partial class allows a single class definition to be divided into multiple files.
    // 3. Each part of class is marked with the `partial` keyword. When compiled, all the parts are
    // combined into a single class definition.

    public class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Method();
            obj.Method1();
        }
    }

    public partial class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
}
