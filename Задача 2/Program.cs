using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountNegative = 0;
            int amountPositive = 0;
            int N;

            Console.WriteLine("Введите последовательность целых чисел");
            do
            {

                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                    amountPositive++;
                else
                    if (N<0)
                    amountNegative++;

            }
            while (N != 0);

            if (amountPositive > amountNegative)
                Console.WriteLine("Кол-во положительных больше ({0})", amountPositive);
            else
                if (amountPositive < amountNegative)
                Console.WriteLine("Кол-во отрицательных больше ({0})", amountNegative);
            else
                if (amountPositive == amountNegative)
                Console.WriteLine("Кол-во отрицательных и положительных одинаково");
            Console.ReadKey();

        }

    }
}
