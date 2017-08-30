using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task4
{
    class Program
    {
        /*
         4.	Даны целые положительные числа A и B(A<B). Вывести все целые числа от A до B включительно;
         каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз,
         равное его значению.Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
         3 3 3
         4 4 4 4
         5 5 5 5 5
         6 6 6 6 6 6
         7 7 7 7 7 7 7
     */
        static void Main(string[] args)
        {
            Write("Введите первое число:");
            string str = ReadLine();
            int numA = Int32.Parse(str);

            Write("Введите второе число:");
            string Str = ReadLine();
            int numB = Int32.Parse(Str);

            if (numA < 0 || numB < 0)
            {
                WriteLine("\nЧисла должны быть положительными!");
                ReadLine();
            }
            WriteLine();
            for (int i = numA; i <= numB; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write(i + " ");
                }
                WriteLine();
            }
            WriteLine("\nНажмите Enter чтобы выйти!");
            ReadLine();
        }
    }
}
