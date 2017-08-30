using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task2
{
    class Program
    {
        /*
           2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-верить
           является ли данный билет счастливым (если на билете напечатано шестизначное число,
           и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
       */
        static void Main(string[] args)
        {
            int numOne = 1000000;
            int numTwo = 100000;
            int tenthousand = 10000;
            int thousond = 1000;
            int hundred = 100;
            int ten = 10;
            WriteLine("Enter the ticket number:");
            string str = ReadLine();
            int num;
            bool number = Int32.TryParse(str, out num);

            if (number || num > numOne || num < numTwo)
            {
                WriteLine("Wrong ticket number!");

            }
            if (num % ten + num % hundred / ten + num % thousond / hundred ==
                num % tenthousand / thousond + num % numTwo / tenthousand + num % numOne / numTwo)
            {
                WriteLine("This ticket is not considered happy!");
            }
            else
            {
                WriteLine("This ticket is considered happy!");
            }
            ReadLine();
        }
    }
}
