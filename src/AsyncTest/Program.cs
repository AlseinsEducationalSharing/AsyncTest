using System;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = A();
            Console.WriteLine("A is running...");
            Console.WriteLine(task.Result);
        }

        private static async Task<int> A() => (await B()) + 1;

        private static async Task<int> B()
        {
            await Task.Delay(3000);
            return 5;

        }
    }
}
