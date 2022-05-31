//  Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
int result = 0;

while (a > 0)
{
    result = a % 2;
    a = a / 2;

}

Console.WriteLine(result);