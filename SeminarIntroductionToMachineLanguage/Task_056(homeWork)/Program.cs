// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] matrix1)
{
    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int n = 0; n < matrix1.GetLength(1); n++)
        {
            matrix1[m, n] = new Random().Next(1, 20);
        }
    }
}
void PrintArray(int[,] matrix2)
{
    for (int m = 0; m < matrix2.GetLength(0); m++)
    {
        for (int n = 0; n < matrix2.GetLength(1); n++)
        {
            Console.Write($"{matrix2[m, n]} ");
        }
        Console.WriteLine();
    }
}
int Sum(int[,] arr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            if (m == 0)
            {
                sum += arr[m, n];
                minSum += arr[m, n];
            }
            else sum += arr[m, n];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = m;
        }
        sum = 0;
    }
    return minNum;
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой элементов: " + Sum(matrix));