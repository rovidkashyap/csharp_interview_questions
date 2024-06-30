using System;

namespace override_function_of_same_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class MyClass
    {
        public void MyMethod()
        {
            Console.WriteLine("No Parameters");
        }
        public void MyMethod(int number)
        {
            Console.WriteLine("With an integer: " + number);
        }
    }

    class BaseClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Base class method");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void MyMethod()
        {
            Console.WriteLine("Derived class method");
        }
    }
}
