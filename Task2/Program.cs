using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите долг: ");
            int doubt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму платежа клиента: ");
            int clientSum = Convert.ToInt32(Console.ReadLine());


            Calculate(clientSum, ref doubt);

            Console.ReadKey();
        }

        static void Calculate(int clientSum, ref int doubt)
        {
            doubt -= clientSum;
            if (doubt <= 0)
            {
                Console.WriteLine($"Долг погашен. Вы переплатили {Math.Abs(doubt)}");
                return;
            }
                
            Console.WriteLine($"У вас еще долг {doubt}. Желаете внести еще платеж? Введите + или -");

            string sign = Console.ReadLine();

            if (sign == "+")
            {
                Console.WriteLine("Введите сумму следующего платежа");
                int newSum = Convert.ToInt32(Console.ReadLine());
                Calculate(newSum, ref doubt);
            } else
            {
                Console.WriteLine($"Увидимся в след. раз! Вам останется внести {doubt}");
            }

        }
    }
}
