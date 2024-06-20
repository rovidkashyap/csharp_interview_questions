using System.Reflection;
using System;

namespace earlyBinding_and_lateBinding
{
    // EARLY BINDING

    // Early binding, also known as static binding or compile-time binding, occurs when the method
    // to be invoked is determined at compile time. In early binding, the compiler has full knowledge
    // of the method being called, including its signature and type. This allows for type checking
    // and optimization by the compiler.

    // LATE BINDING

    // Late binding, also known as dynamic binding or runtime binding, occurs when the method to be
    // invoked is determined at runtime. In late binding, the exact method that will be called is
    // not known until the code is actually executed. This is often used in scenarios where the
    // method or object might not be known at compile time.

    public class Program
    {
        static void Main(string[] args)
        {
            // Late binding using reflection
            Assembly assembly = Assembly.Load("mscorlib");
            Type type = assembly.GetType("System.String");
            MethodInfo methodInfo = type.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

            string str = "Hello, World!";
            object[] parameters = new object[] { 7, 5 };
            string result = (string)methodInfo.Invoke(str, parameters);

            Console.WriteLine(result); // Output: World
        }
    }
}
