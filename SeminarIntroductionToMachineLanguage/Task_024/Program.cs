// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите натуральное число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int sumResult = GetSumNumbers(num);

Console.WriteLine($"Сумма чисел от 1 до {num} = {sumResult}");