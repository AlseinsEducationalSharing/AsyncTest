using System;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        private static int num = 6;
        static void Main(string[] args)
        {
            A();
            //num = Console.ReadKey(true).KeyChar;
            int sum = 0;
            while (true)
            {
                sum = Console.ReadKey(true).KeyChar - 48;
                if (sum > 0 && sum < 10)
                {
                    num = sum;
                }
            }
        }

        private static async void A()
        {
            while (true)
            {
                await Task.Delay(1000);
                Console.WriteLine($"输出了{num}个*");
            }
        }
    }
}
