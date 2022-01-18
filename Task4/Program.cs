using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N=");
            int N = Convert.ToInt32(Console.ReadLine());
            int kvadratChisla=0;
            for (int i = 1; i <= N; i++)
            {
                kvadratChisla += 2 * i - 1;
                Console.WriteLine(kvadratChisla);
            }
            Console.WriteLine("Квадрат числа={0}", kvadratChisla);
            Console.ReadKey();

        }
    }
}
