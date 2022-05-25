// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetSumInDigit(int number)
{
    int sumDigit = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sumDigit = sumDigit + digit;
        number = number / 10;
    }
    return sumDigit;
}
int sumResult = GetSumInDigit(num);

Console.WriteLine($"Сумма цифр в числе {num} = {sumResult}");