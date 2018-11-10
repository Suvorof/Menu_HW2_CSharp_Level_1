using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_HW2_CSharp_Level_1
{
    partial class Program
    {
        // *Написать программу подсчёта количества "хороших" чисел в диапазоне от 1 до 1000 000 000. "Хорошим" называется число, которое делится на сумму своих цифр.
        // Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

        static void Task6Sum()
        {
            int minNumber = 1;
            int maxNumber = 1000000000;
            int gns_amount = 0;
            int amountNumbers = 0;

            DateTime start = DateTime.Now;
            Console.WriteLine("Количество \"хороших\" чисел в интервале от 1 до 1 000 000 000 (нужно подождать...)");
            for (int i = minNumber; i < maxNumber; i++)
            {
                amountNumbers = CalculateNumbers(i);
                if ((i % amountNumbers) == 0)
                    gns_amount++;
            }
            DateTime finish= DateTime.Now;
            Console.WriteLine($"составило {gns_amount:N0} штук. Время работы программы по подсчёту \"хороших\" чисел, составило {finish - start}.\nДля выхода нажмите любую клавишу.");
            Console.ReadKey();


        }

        static int CalculateNumbers(int i)
        {
            int count = 0;
            while (i > 0)
            {
                i = i / 10;
                count++;
            }
            return count;

        }

    }
}
