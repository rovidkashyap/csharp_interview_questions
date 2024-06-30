using System;
using System.Threading.Tasks;

namespace async_and_await_keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FetchDataAsync();
        }

        public static async Task<int> FetchDataAsync()
        {
            // Simulate an asynchornous operation
            await Task.Delay(1000);
            return 42;
        }

        public static async Task ProcessDataAsync()
        {
            int result = await FetchDataAsync();
            Console.WriteLine($"Result: {result}");
        }
    }
}
