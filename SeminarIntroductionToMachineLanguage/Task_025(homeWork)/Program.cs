// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int extent = int.Parse(Console.ReadLine());
int count = 1;
int result = num;

while (count < extent)
{
    result = result * num;
    count++;
}

System.Console.WriteLine($"{num} ^ {extent} = {result}");