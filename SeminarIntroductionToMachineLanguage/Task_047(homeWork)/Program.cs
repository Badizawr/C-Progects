// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// Пример:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;
double[,] array = new double[m, n];

void FillArray(double[,] arr)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().NextDouble() * 20 - 10;
        }
    }
}
void PrintArray(double[,] arr1)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);