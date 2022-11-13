using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Calculate(a, b, c));

            Console.ReadKey();
        }

        static (int, int, int) Calculate(int a, int b, int c)
        {
            return (a / 5, b / 5, c / 5);
        }
    }
}
