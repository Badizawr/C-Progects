// Напишите программу которая принимает на ввод  трёхзначное число
// и на выходе показывает последнее цифру

Console.Write("Введите техзначное число -> ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Последнее число -> " + num % 10);
