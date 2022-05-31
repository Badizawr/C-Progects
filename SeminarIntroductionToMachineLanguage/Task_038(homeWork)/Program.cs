// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];

var newRnd = new Random();
for (int i = 0; i < size; i++)
{
    nums[i] = newRnd.Next(1, 10);
    Console.Write(nums[i] + " ");
}

int difference = nums.Max() - nums.Min();

Console.WriteLine();
Console.WriteLine($"Минимальное значение массива {nums.Min()}, максимальное значение массива {nums.Max()}");
Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");