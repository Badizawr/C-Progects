// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 
System.Console.Write("Введите число:   ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number;

int count = 0;
for (result = number; result > 0; count++) 
{
    result = result /10;
}
System.Console.WriteLine($"В числе {number}  количество цифр = {count}");