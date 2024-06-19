using System;

namespace access_specifiers
{
    // TYPES OF ACCESS SPECIFIERS -

    // 1. 'PUBLIC' - Accessible from any Code.
    // 2. 'PRIVATE' - Accessible only within the containing class.
    // 3. 'PROTECTED' - Accessible within the containg class and derived classes.
    // 4. 'INTERNAL' - Accessible within the same assembly.
    // 5. 'PROTECTED INTERNAL' - Accessible within the same assembly or any derived class.
    // 6. 'PRIVATE PROTECTED' - Accessible within the containing class and derived class and derived classes within the same assembly.

    #region PUBLIC CLASS
    public class PublicClass
    {
        public int PublicField;
        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
        }
    }
    #endregion

    #region PRIVATE CLASS
    public class PrivateClass
    {
        private int PrivateField;
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }
    }
    #endregion

    #region PROTECTED CLASS
    public class BaseClass
    {
        protected int ProtectedField;
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method");
        }
    }
    public class DerivedClass: BaseClass
    {
        public void UseProtectedMember()
        {
            ProtectedField = 10;    // Accessible in derived class
            ProtectedMethod();      // Accessible in derived class
        }
    }
    #endregion

    #region INTERNAL CLASS
    internal class InternalClass
    {
        internal int InternalField;
        internal void InternalMethod()
        {
            Console.WriteLine("Internal Member");
        }
    }

    #endregion

    #region PROTECTED INTERNAL CLASS
    public class ProtectedInternalClass
    {
        protected internal int ProtectedInternalField;
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal method");
        }
    }
    #endregion

    #region PRIVATE PROTECTED
    public class PrivateProtectedClass
    {
        private protected int PrivateProtectedField;
        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("Private Protected Method");
        }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
