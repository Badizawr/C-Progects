// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

// мой вариант
System.Console.Write("Введите число:   ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number;

int count = 0;
for (result = number; result > 0; count++)
{
    result = result / 10;
}
System.Console.WriteLine($"В числе {number}  количество цифр = {count}");

// Вариант с записи
// System.Console.Write("Введите число:   ");
// int number = int.Parse(Console.ReadLine());
// if (number < 0) number = number * -1;

// int FindNumV (int num)
// {
//     int div =1;
//     int num2 = 0;
//     int count = 0;
//     while (num2 > div)
//     {
//         num2 = num2/ div;
//         div = div * 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine($"Количество цифр в числе = {FindNumV(number)}");