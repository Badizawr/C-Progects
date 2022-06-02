// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("До какого числа делаем вывод: ");
int size = int.Parse(Console.ReadLine());
int nums = 0;
int nums2 = 1;
int[] numbers = new int[size];
//int count = 0;

for (int i = 0; i <= size; i++)
{
    nums2 = nums2 + nums;
    
}