using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string A = Console.ReadLine();
            int lenght = A.Length;
            //Console.WriteLine(lenght);
            int N = int.Parse(A);
            int M = 0;
            while (N>0)
            {
                M += (N % 10) * (int)Math.Pow( 10, lenght - 1);
                lenght--;
                N /= 10;
            }
            Console.WriteLine(M);
        }
    }
}
