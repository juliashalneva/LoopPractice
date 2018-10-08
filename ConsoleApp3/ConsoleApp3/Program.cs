using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string str = "((())))";
            int count = 0;
            int count2 = 0;
            int bracket = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "(")
                {
                    count++;
                    bracket++;
                }

                if (str[i].ToString() == ")") count2++;

                if (count-count2 < 0)
                {
                    flag = false;
                    break;
                }
            }

            if (flag) Console.WriteLine("Корректное выражение");
            else Console.WriteLine("Некорректное выражение");
            if (flag) Console.WriteLine("Вложенность: " + bracket);
        }
    }
}
