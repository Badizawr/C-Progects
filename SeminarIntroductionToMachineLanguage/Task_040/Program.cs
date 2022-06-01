// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами
// такой длины.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine(a < b + c && b < a + c && c < b + a? "Может" : "Не может");