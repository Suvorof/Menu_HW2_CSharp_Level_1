using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_HW2_CSharp_Level_1
{
    partial class Program
    {
        static double minAmongThreeDigits(double a, double b, double c)
        {
            // Написать метод, возвращающий минимальное из трёх чисел.
            // Суворов К.А.

            if (a < b && a < c)
                return a;
            else if (b < a && b < c)
                return b;
            else return c;
        }

        static void Task1Minimum()
        {
            double firstDigit, secondDigit, thirdDigit;
            Console.Title = "Константин Суворов. Санкт-Петербург.";
            Console.WriteLine("Здравствуйте! Вас приветствует программа по нахождению минимального значения из трёх введённых Вами чисел:");
            Console.Write("Введите первое число: ");
            firstDigit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            secondDigit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            thirdDigit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Минимальным числом из трёх введённых Вами: {firstDigit}, {secondDigit}, {thirdDigit} является {minAmongThreeDigits(firstDigit, secondDigit, thirdDigit)}.");
            Console.WriteLine("Для выхода нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
