using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_HW2_CSharp_Level_1
{
     partial class Program
    {
        // Реализовать метод проверки логина и пароля. На вход метода подаётся логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел
        // (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа
        // пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
        // Суворов К.А. Санкт-Петербург.

        static bool ChekLogin(string usersLogin)
        {
            string login = "root";

            if (login == usersLogin)
            {
                Console.WriteLine("Логин принят!");
                return true;
            }
            else
            {
                Console.WriteLine("Вы ввели неправильный логин.");
                return false;
            }
        }

        static bool CheckPassword(string usersPassword)
        {
            string password = "GeekBrains";

            if (password == usersPassword)
            {
                Console.WriteLine("Вы ввели правильный пароль.");
                return true;
            }
            else
            {
                Console.WriteLine("Вы ввели неправильный пароль.");
                return false;
            }
        }

        static void Task4ChekLoginAndPass()
        {
            Console.Title = "Константин Суворов. Санкт-Петербург.";
            int counter = 0;
            int tryQuantity = 3;
            do
            {
                counter++;
                Console.Write("Введите Ваш логин: ");
                string userLog = Convert.ToString(Console.ReadLine());
                if (ChekLogin(userLog) == true)
                {
                    Console.Write("Введите Ваш пароль: ");
                    string userPass = Convert.ToString(Console.ReadLine());
                    if (CheckPassword(userPass) == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Попробуйте ввести пароль снова: ");
                        string userPassReWrite = Convert.ToString(Console.ReadLine());
                        if (CheckPassword(userPassReWrite) == true)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine($"У Вас осталось {tryQuantity - counter} попытки.");
            }
            while (counter < tryQuantity);
            Console.WriteLine("Для выхода нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
