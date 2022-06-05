// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("До какого числа делаем вывод: ");
int size = int.Parse(Console.ReadLine());
int sum = 0;
Console.Write("{0} ", sum);
int num1 = 1;
Console.Write("{0} ", num1);
int num2 = 1;
Console.Write("{0} ", num2);


for (int i = 3; i <= size-1; i++)
{
    sum = num1 + num2;
    Console.Write("{0} ", sum);
    num1 = num2;
    num2 = sum;
}