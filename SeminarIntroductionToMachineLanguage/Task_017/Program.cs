// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату X: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("Диапазон находится в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Диапазон находится во 2 четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Диапазон находится в 3 четверти");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Диапазон находится в 4 четверти");
}