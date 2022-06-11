// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

void PrintArray(int[,] matrix1)
{
    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int n = 0; n < matrix1.GetLength(1); n++)
        {
            Console.Write($"{matrix1[m, n]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matrix2)
{
    for (int m = 0; m < matrix2.GetLength(0); m++)
    {
        for (int n = 0; n < matrix2.GetLength(1); n++)
        {
            matrix2[m, n] = new Random().Next(1, 10);
        }
    }
}
void Ordering(int[,] matrix3)
{
    if (matrix3.GetLength(0) == matrix3.GetLength(1))
    {
        int[,] nums = new int[matrix3.GetLength(0), matrix3.GetLength(1)];
        for (int m = 0; m < matrix3.GetLength(0); m++)
        {
            for (int n = 0; n < matrix3.GetLength(1); n++)
            {
                nums[m, n] = matrix3[m, n];
            }
        }
        for (int m = 0; m < matrix3.GetLength(0); m++)
        {
            for (int n = 0; n < matrix3.GetLength(1); n++)
            {
                matrix3[m, n] = nums[n, m];
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратная");
    }
}
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Ordering(matrix);
PrintArray(matrix);