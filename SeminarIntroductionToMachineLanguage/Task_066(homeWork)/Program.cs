// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
SumNumber(m, n, temp = 0);

void SumNumber(int numM, int numN, int sum)
{
    sum = sum + numN;
    if (numN <= numM)
    {
        Console.Write($"Сумма элементов -> {sum} ");
        return;
    }
    SumNumber(numM, numN - 1, sum);
}