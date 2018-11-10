using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_HW2_CSharp_Level_1
{
    partial class Program
    {
        static int numberOfDigits(int a)
        {
            // Написать метод подсчёта количества цифр числа.
            // Суворов К.А.

            int n = 0;
            while (a != 0)
            {
                n++;
                a = a / 10;
            }
            return n;
        }

        static void Task2NumberOfDigits ()
        {
            int digit;
            Console.Title = "Константин Суворов. Санкт-Петербург";
            Console.WriteLine("Здравствуйте, Вас приветствует программа по подсчёту количества цифр в введённом числе.");
            Console.Write("Введите любое целое число: от 0 до 4 294 967 295 включительно: ");
            digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество цифр в введённом Вами числе {digit} равно: {numberOfDigits(digit)}.");
            Console.WriteLine("Для выхода нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
