using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество клиентов:");
            int clientsNumber = Convert.ToInt32(Console.ReadLine());

            GetRoadsNumber(clientsNumber, 1);
            Console.ReadKey();
        }

        static void GetRoadsNumber(int clientsNumber, int roadNumber)
        {
            int roadNumberVar = roadNumber;
            int clientsNumberVar = clientsNumber;

            if(clientsNumberVar > 0)
            { 
                roadNumberVar *= clientsNumberVar;
                clientsNumberVar--;
                GetRoadsNumber(clientsNumberVar, roadNumberVar);
            } else
            {
                Console.WriteLine($"Количество дорог {roadNumberVar}");
            }
        }


    }
}
