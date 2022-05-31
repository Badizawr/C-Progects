// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];
int count = 0;
var newRnd = new Random();

for (int i = 0; i < size; i++)
{
    nums[i] = newRnd.Next(100, 1000);
    Console.Write(nums[i] + " ");
}

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)  count++;
}

Console.WriteLine();
Console.WriteLine("количество чётных чисел в массиве " + count);