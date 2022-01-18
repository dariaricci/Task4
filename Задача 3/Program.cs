using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число А");
            decimal A = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите положительное число B");
            decimal B = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите положительное число C");
            decimal C = Convert.ToDecimal(Console.ReadLine());
            decimal P = C;
            decimal N = C;
            int amountA = 0;
            int amountB = 0;
            int S = 0;
            while (P <= A)
            {

                P += C;
                amountA++;
            }
            while (N <= B)
            {
                N += C;
                amountB++;
            }
           
                for (int i = 0; i < amountA; i++)
                {
                    S += amountB;
                }
            
            Console.WriteLine("Максимальное количество квадратов= {0}", S);
            Console.ReadKey();
        }
    }
}
