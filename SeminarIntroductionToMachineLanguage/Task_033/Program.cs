// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Число которое необходимо найти: ");
int num = int.Parse(Console.ReadLine());
int[] array = new int[size];
var newRnd = new Random();
string result = "Нет";

Console.WriteLine("Исходный массив:");
for (int i = 0; i < size; i++)
{
    array[i] = newRnd.Next(-9, 25);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < size; i++)
{
    if(array[i] == num) result = "Да";
}
Console.WriteLine(result);