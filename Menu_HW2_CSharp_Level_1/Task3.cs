using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_HW2_CSharp_Level_1
{
   partial class Program
    {
        static void Task3SummAllOdd ()
        {
            // С клавиатуры вводятся числа, пока не будет введён 0. Подсчитать сумму всех нечётных положительных чисел.
            // Суворов К.А.

            Console.Title = "Константин Суворов. Санкт-Петербург.";
            Console.WriteLine("Вас приветствует программа по подсчёту суммы нечётных чисел из тех, которые Вы будете вводить.\nСумма будет подсчитываться до тех пор пока Вы не введёте ноль.\n");
            int digit, sum = 0;
            do
            {
                Console.WriteLine("Введите любое целое число: от 0 до 4 294 967 295 включительно: ");
                digit = Convert.ToInt32(Console.ReadLine());
                if (digit % 2 != 0 && digit != 0)
                {
                    sum += digit;
                    Console.WriteLine($"Сумма нечётных чисел равна {sum}.\n");
                }
                else if (digit % 2 == 0 && digit != 0)
                    Console.WriteLine("Чётные числа не суммируются, продолжайте вводить числа.\n");
                else if (digit == 0)
                    Console.WriteLine("Вы ввели ноль, программа будет завершена, нажмите любую клавишу.\n");
            }
            while (digit != 0);
            Console.ReadKey();
        }
    }
}
