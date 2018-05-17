using System;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        private static int _num = 6;
        private static int Num
        {
            get => _num;
            set => _num = value > 0 && value < 10 ? value : _num;
        }

        static void Main(string[] args)
        {
            Output();
            while (true)
            {
                Num = Console.ReadKey(true).KeyChar - '0';
            }
        }

        private static async void Output()
        {
            while (true)
            {
                await Task.Delay(1000);
                Console.WriteLine(new string(Enumerable.Range(0, _num).Select(x => '*').ToArray()));
            }
        }
    }
}
