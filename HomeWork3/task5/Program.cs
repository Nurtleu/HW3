using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task5
{
    class Program
    {
        /*
          5.Дано целое число N(> 0), найти число, полученное при прочтении числа N справа налево.
            Например, если было введено число 345, то программа должна вывести число 543.
        */   
        static void Main(string[] args)
        {
            WriteLine("Введите число:");
            string str = ReadLine();
            int num = Int32.Parse(str);
            int Num = 0;
            while (num > 0)
            {
                Num += num % 10;
                num /= 10;
                Num *= 10;
            }
            Num /= 10;

            Write("Ответ : " + Num);

            ReadLine();
        }
    }
}
