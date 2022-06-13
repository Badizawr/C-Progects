// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
SumNumber(n, 0);

void SumNumber(int num, int sum)
{
    if (num == 0)
    {
        Console.WriteLine($"сумма числа равна -> {sum}");
        return;
    }

    sum = sum + num % 10;
    num = num / 10;
    SumNumber(num, sum);
}
