// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());


void PrintNatNum(int n, int m)
{
if(n == m)
{
Console.Write($"{n} ");
return;
}
if (m < n)
{
PrintNatNum(n-1, m);
Console.Write($"{n} ");
}
else
{
PrintNatNum(n+1, m);
Console.Write($"{n} ");
}
}

PrintNatNum(n, m);


Console.ReadKey();