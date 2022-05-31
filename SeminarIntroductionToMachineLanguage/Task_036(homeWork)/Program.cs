// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];
int sum = 0;
var newRnd = new Random();

for (int i = 0; i < size; i++)
{
    nums[i] = newRnd.Next(1, 10);
    Console.Write(nums[i] + " ");
}

for (int i = 0; i < size; i++)
{
    if (i % 2 > 0) sum += nums[i];
}

Console.WriteLine();
Console.WriteLine("Сумма нечётных чисел равна " + sum);