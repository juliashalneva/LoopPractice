using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 1, 1, 2, 1, 1, 1, 1, 1 };
            Random rand = new Random();
            //for (int i=0; i<array.Length; i++) array[i] = rand.Next();
            int count = 1;
            int max = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                    if(max < count) max = count;
                    //Console.WriteLine(count);
                }
                else
                {
                    if (max < count) max = count;
                    count = 1;
                }
            }
            Console.WriteLine(max);

        }
    }
}
