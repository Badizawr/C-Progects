// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

static void distance()
{
Console.WriteLine("Введите кординаты первой точки: ");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите кординаты второй точки: ");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
double distance = Math.Round(result, 2);
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
}