// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] array = new int[6, 5];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 20);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
int m = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    m = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = array[0, i];
    array[0, i] = m;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
} 