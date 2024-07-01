namespace implicit_and_explicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Type Conversion - Safe, automatic, and requires no explicit syntax. Used between
            //                            compatible types where no data loss occurs.
            //                          - Compiler handles the conversion.

            // Explicit Type Conversion - Requires explicit syntax using the cast operator, may result in
            //                            data loss or exceptions, and is used between incompatible types
            //                            or where precision might be lost.
            //                          - Developer must handle the conversion and potential errors.

            #region Implicit Conversion
            short smallNumber = 10;
            int largerNumber = smallNumber;     // Implicit conversion from short to int

            float myFloat = 5.75f;
            double myDouble = myFloat;          // Implicit conversion from float to double
            #endregion

            #region Explicit Conversion
            double myDouble_2 = 9.78;
            int myInt = (int)myDouble_2;    // Explicit conversion from double to int, fractional part is lost

            int largeNumber = 123456;
            short smallNumber_2 = (short)largeNumber;   // Explicit conversion from int to short, potential data loss

            object obj = 100;
            int myNum = (int)obj;       // Explicit conversion from object to int
            #endregion

        }
    }
}
