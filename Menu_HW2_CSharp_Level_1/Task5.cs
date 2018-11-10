using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_HW2_CSharp_Level_1
{
    partial class Program
    {
        // а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        // б) Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

        public static void Task5Index ()
        {
            double index;
            double indexOfDeficitWeight = 16;
            double indexOfNormalWeight = 22;
            double indexOfOverWeight = 33;
            Console.Write("Введите свой вес в килограммах: ");
            double usersWeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой рост в сантиметрах: ");
            double usersHeight = Convert.ToDouble(Console.ReadLine());

            usersHeight = usersHeight / 100; // делим на 100, чтобы перевести в метры
            index = usersWeight / (usersHeight * usersHeight);

            if(index <= indexOfDeficitWeight)
            {
                double correctUsersWeight;
                correctUsersWeight = indexOfNormalWeight * (usersHeight * usersHeight);
                Console.WriteLine($"У Вас острый дефицит веса. Для номализации веса Вам следует набрать {correctUsersWeight - usersWeight:F0} кг.\nДля выхода нажмите любую клавишу.");
                Console.ReadKey();
            }
            else if (index > indexOfDeficitWeight & index <= indexOfNormalWeight)
            {
                double correctUsersWeight;
                correctUsersWeight = indexOfNormalWeight * (usersHeight * usersHeight);
                Console.WriteLine($"У Вас дефицит веса. Для номализации веса Вам следует набрать {correctUsersWeight - usersWeight:F0} кг.\nДля выхода нажмите любую клавишу.");
                Console.ReadKey();
            }
            else if (index >= indexOfNormalWeight-1 & index <= indexOfNormalWeight+1) // ввожу диапазон нормального ИМТ 22-1:22+1
            {
                Console.WriteLine("У Вас нормальный вес. Коррекция  веса не требуется. Для выхода нажмите любую клавишу.");
                Console.ReadKey();
            }
            else if (index > indexOfNormalWeight+1 & index < indexOfOverWeight)
            {
                double correctUsersWeight;
                correctUsersWeight = indexOfNormalWeight * (usersHeight * usersHeight);
                Console.WriteLine($"У Вас ожирение. Для номализации веса Вам следует сбросить {usersWeight - correctUsersWeight:F0} кг.\nДля выхода нажмите любую клавишу.");
                Console.ReadKey();
            }
            else if (index >= indexOfOverWeight)
            {
                double correctUsersWeight;
                correctUsersWeight = indexOfNormalWeight * (usersHeight * usersHeight);
                Console.WriteLine($"У Вас сильное ожирение. Для номализации веса Вам следует сбросить {usersWeight - correctUsersWeight:F0} кг.\nДля выхода нажмите любую клавишу.");
                Console.ReadKey();
            }
        }
    }
}
