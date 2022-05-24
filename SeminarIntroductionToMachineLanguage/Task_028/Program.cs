// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int SummNumber(int num)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
    }
    return sum;
}
int result = SummNumber(number);

Console.WriteLine($"произведение чисел от 1 до {number} = {result}");