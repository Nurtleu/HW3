using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork3
{
    class Program
    {
        /* 
            1.Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
            Программа должна сосчитать количество введенных пользователем пробелов.
        */
        static void Main(string[] args)
        {
            char symbol;
            int CountSpaces = 0;
            WriteLine("Введите текст:");
            do
            {
                symbol = ReadKey().KeyChar;
                if (symbol == ' ')
                    CountSpaces++;

            } while (symbol != '.');
            Write("\nВашем тексте пробелов:" + CountSpaces);
            ReadLine();
        }
    }
}
