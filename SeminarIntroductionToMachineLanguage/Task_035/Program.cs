internal class Program
{
    private static void Main(string[] args)
    {
        // Задайте одномерный массив из 123 случайных чисел.
        // Найдите количество элементов массива, значения которых лежат в отрезке[10, 99].
        // Пример для массива из 5, а не 123 элементов.В своём решении сделайте для 123
        // [5, 18, 123, 6, 2]-> 1
        // [1, 2, 3, 6, 2]-> 0
        // [10, 11, 12, 13, 14]-> 5

        Console.Write("Задайте размер массива: ");
        int size = int.Parse(Console.ReadLine());
        int[] nums = new int[size];
        var newRnd = new Random();
        int count = 0;

        for (int i = 0; i < size; i++)
        {
            nums[i] = newRnd.Next(0, 200);
            Console.Write(nums[i] + " ");
        }

        for (int i = 0; i < size; i++)
        {
            if (nums[i] >= 10 && nums[i] <= 99) count++;

        }
        Console.WriteLine();
        Console.WriteLine("Количество значений которых лежат в отрезке[10, 99]" + count);
    }

}