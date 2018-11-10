using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_HW2_CSharp_Level_1
{
    partial class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Константин Суворов. Санкт-Петербург.";
            Console.WriteLine("Здравствуйте! Выберите задание, которое хотите протестировать:\n1. Минимальное из трёх чисел.\n2. Метод подсчёта количества цифр в введённом числе.\n3. Сумма всех нечётных чисел.\n4. Метод проверки логина и пароля.\n5. Вычисление ИМТ и рекомендация по нормализации веса.\n6. Программа подсчёта \"хороших\" чисел.");
            int numberOfTask = Convert.ToInt32(Console.ReadLine());

            switch (numberOfTask)
            {
                case 1:
                    Task1Minimum();
                    break;
                case 2:
                    Task2NumberOfDigits();
                    break;
                case 3:
                    Task3SummAllOdd();
                    break;
                case 4:
                    Task4ChekLoginAndPass();
                    break;
                case 5:
                    Task5Index();
                    break;
                case 6:
                    Task6Sum();
                    break;
            }
        }
    }
}
