// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// Примеры:
// 6 -> да
// 7 -> да
// 1 -> нет

using System;

namespace SeminarIntroductionToMachineLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи цифру, обозначающую день недели: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            static void CheckingTheDayOfTheWeek(int dayNumber)
            {
                if (dayNumber == 6 || dayNumber == 7)
                {
                    Console.Write("-> да");
                }
                else if (dayNumber < 1 || dayNumber > 7)
                {
                    Console.Write("-> это не день недели");
                }
                else Console.Write("-> нет");
            }

            CheckingTheDayOfTheWeek(dayNumber);
        }



    }
}
