namespace Managed_and_Unmanaged
{
    public class Program
    {
        static void Main(string[] args)
        {
            // MANAGED CODE -   (EXAMPLE IS C# PROGRAM CODE)

            // 1. It is code that exexuted by The Command Language Runtime (CLR) in the .Net Framework.
            // 2. The CLR provides various services such as garbage collection, exception handling, and
            // type safety, which help ensure safe execution of code.
            // 3. The CLR Provides the structured exception handling.
            // 4. The CLR runs within a controlled environment, making it more secure against malicious
            // activities
            // 5. The C# Code compiles into a Intermediate Language (IL) and executed by the CLR.

            // UNMANAGED CODE - (EXAMPLE IS C PROGRAM CODE)

            // 1. Unamanaged code is executed directly by the operating system. It is written in languages
            // like C or C++ and compiled into machine code that runs directly on the hardware.
            // 2. Unamanged code does not have benefits of the CLR and must handle memory management,
            // type safety and security manually.
            // 3. Manual Managament of memory allocation and deallocation using functions like 'malloc'
            // and 'free' in C programming.
            // 4. The developer must ensure correct type usage.
            // 5. Unmanaged code run outside the control of CLR, making it potentially less secure and more
            // susceptible to vulnerabilities like buffer overflows.
            // 6. Typically Platform-dependentm as it is compiled into machine-specific code.
            // 7. The C code is compiled into machine code and executed directly by the operating system.
        }
    }
}
