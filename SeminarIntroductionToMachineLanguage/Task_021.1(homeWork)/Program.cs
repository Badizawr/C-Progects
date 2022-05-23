//  Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

namespace Task_021._1_homeWork_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кординаты первой точки: ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите кординаты второй точки: ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());
            double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
            double distance = Math.Round(result, 2);
            Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
        }
    }
}
