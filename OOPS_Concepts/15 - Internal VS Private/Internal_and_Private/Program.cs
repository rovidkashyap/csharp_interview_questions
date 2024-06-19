using System;
using System.Runtime.CompilerServices;

namespace Internal_and_Private
{
    // PRIVATE ACCESS MODIFIERS

    //1. The 'private' access modifiers restricts access to the containing class or struct.
    //2. Members declared as 'private' are accessible only within the same class or struct.
    //3. They cannot be accessed from outside the class or struct, including derived classes.
    //4. Typically used to hide implementation details and to encapsulate members
    // that should not be accessible outside the class.

    // INTERNAL ACCESS MODIFIERS

    //1. 'internal' access modifier accessible within the same assembly.
    //2. Used to allow access to members across the same assembly while hiding them from assemblies.
    //3. Visible to all types within the same assembly but not outside the assembly.

    class MyClass
    {
        private int myPrivateField = 10;
        internal int MyInternalField = 10;

        internal void MyInternalMethod()
        {
            Console.WriteLine("This is an Internal method.");
        }

        private void MyPrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }
        public void AccessPrivateMembers()
        {
            Console.WriteLine($"Private Field: {myPrivateField}");
            MyPrivateMethod();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            // obj.myPrivateField = 20;    // Compile-time error
            // obj.MyPrivateMethod();      // Compile-time error
            obj.AccessPrivateMembers();    // This is allowed

            obj.MyInternalField = 20;       // This is allowed
            obj.MyInternalMethod();         // This is allowed
        }
    }
}
