using System;

namespace Virtual
{
    // VIRTUAL KEYWORD - DECLARES A METHOD THAN CAN BE OVERRIDEN IN DERIVED CLASS.
    // OVERRIDE KEYWORD - PROVIDES A NEW IMPLEMENTATION OF A VIRTUAL METHOD FROM THE BASE CLASS.
    // NEW KEYWORD - HIDES A METHOD FROM BASE CLASS CREATING A NEW METHOD WITH THE SAME NAME IN THE DERIVED CLASS.
    public class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Base Class Display Method.");
        }
    }
    public class DerivedClass : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("Derived class display method.");
        }
    }
    public class newDerivedClass : BaseClass
    {
        public new void Display()
        {
            Console.WriteLine("Derived class display method with new keyword");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- Virtual/Override Keyword Example --------------");
            
            BaseClass baseObj = new BaseClass();
            baseObj.Display();          // Outputs: Base class display method.

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.Display();       // Outputs: Derived class display method.

            BaseClass baseDerivedObj = new DerivedClass();
            baseDerivedObj.Display();   // Outputs: Derived class display method.

            Console.WriteLine();
            Console.WriteLine("---------------------- New Keyword -------------------------");
            
            BaseClass baseObj1 = new BaseClass();
            baseObj1.Display();         // Outputs: Base class display method.

            DerivedClass derivedObj1 = new DerivedClass();
            derivedObj1.Display();      // Outputs: Derived Class display method.

            BaseClass baseDerivedObj1 = new newDerivedClass();
            baseDerivedObj1.Display();  // Outputs: Base class display method.

            newDerivedClass newDerivedObj = new newDerivedClass();
            newDerivedObj.Display();    // Outputs: Derived class display method with new keyword.
        }
    }
}
