// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите число A :");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B :");
int b = int.Parse(Console.ReadLine());
bool result = b == a * a || a == b * b;
Console.WriteLine(result ? "Да" : "Нет");