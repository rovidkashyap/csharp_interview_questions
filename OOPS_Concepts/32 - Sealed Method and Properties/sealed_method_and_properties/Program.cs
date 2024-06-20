using System;

namespace sealed_method_and_properties
{
    // SEALED METHOD is an overriden method that cannot be overriden again in any derived class.
    // This is useful when you want to finalize the implementation of a method in derived class
    // and prevent any further modification by subclass.

    // SEALED PROPERTIES is a property that has been overriden and then sealed to prevent
    // further overriding in any derived class.

    #region SEALED CLASS AND PROPERTIES
    public class BaseClass
    {
        // Virtual Method in base class
        public virtual void Display()
        {
            Console.WriteLine("Display method in BaseClass");
        }

        // Virtual Property in base class
        public virtual string Name { get; set; }
    }
    public class DerivedClass : BaseClass
    {
        // overriding the virtual method
        public override void Display()
        {
            Console.WriteLine("Display method in DerivedClass");
        }

        // Overriding the virtual property
        public override string Name { get; set; }
    }
    public class FurtherDerivedClass : DerivedClass
    {
        // Attempting to override a sealed method would cause a compile-time error
        public sealed override void Display()
        {
            Console.WriteLine("Sealed Display methon in FurtherDerivedClass");
        }

        // Sealing the overriden property
        public sealed override string Name { get; set; }
    }
    public class FinalClass : FurtherDerivedClass
    {
        // This would cause a compile-time error becuase the method is sealed in FurtherSerivedClass
        //public override void Display()
        //{
        //    Console.WriteLine("Display method in FinalClass");
        //}

        // This would cause a compile-time error because the property is sealed in FurtherDerivedClass
        //public override string Name { get; set; }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            FinalClass obj = new FinalClass();
            obj.Display();

            obj.Name = "Rovid";
            Console.WriteLine(obj.Name);
        }
    }
}
