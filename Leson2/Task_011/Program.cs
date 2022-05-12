// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
//Console.WriteLine($"Number = {number}");
int last = number % 10;
int first = number / 100;
int res = first * 10 + last;
Console.WriteLine($"Случайное число = {number}");
Console.WriteLine($"Результат = {res}");
