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
            Console.Title = "���������� �������. �����-���������.";
            Console.WriteLine("������������! �������� �������, ������� ������ ��������������:\n1. ����������� �� ��� �����.\n2. ����� �������� ���������� ���� � �������� �����.\n3. ����� ���� �������� �����.\n4. ����� �������� ������ � ������.\n5. ���������� ��� � ������������ �� ������������ ����.\n6. ��������� �������� \"�������\" �����.");
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
