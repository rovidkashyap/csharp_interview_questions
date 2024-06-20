using System;
using System.Threading.Tasks;

namespace multiple_exception_at_once
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region USING MULTIPLE CATCH BLOCKS
            try
            {
                ThrowMultipleExceptions();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Caught ArgumentNullException: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Caught InvalidOperationException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught General Exception: {ex.Message}");
            }
            #endregion

            #region SINGLE CATCH BLOCK WITH `WHEN`
            try
            {
                ThrowMultipleExceptions();
            }
            catch (Exception ex) when (ex is ArgumentNullException || ex is InvalidOperationException)
            {
                Console.WriteLine($"Caught Specific Exception: {ex.GetType()} - {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught General Exception: {ex.Message}");
            }
            #endregion

            #region USING `AGGREGATEEXCEPTION`
            try
            {
                Task task1 = Task.Run(() => { throw new InvalidOperationException("Invalid operation"); });
                Task task2 = Task.Run(() => { throw new ArgumentNullException("paramName", "Parameter cannot be null."); });

                Task.WaitAll(task1, task2);
            }
            catch (AggregateException ex)
            {
                foreach (var innerEx in ex.InnerExceptions)
                {
                    Console.WriteLine($"Caught Exception: {innerEx.GetType()} - {innerEx.Message}");
                }
            }
            #endregion
        }
        static void ThrowMultipleExceptions()
        {
            // Simulate an exception
            throw new ArgumentNullException("paramName", "Parameter cannot be null.");
        }
    }
}
