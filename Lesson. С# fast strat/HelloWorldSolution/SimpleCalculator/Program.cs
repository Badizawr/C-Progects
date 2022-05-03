// Сделаем простой калькулятор с выводом нескольких вариантов ответов

Console.Write("Введитите число а -> ");
String a = Console.ReadLine();
Console.Write("Введите число b -> ");
String b = Console.ReadLine();

int num1 = Convert.ToInt32(a);
int num2 = Convert.ToInt32(b);

int result = num1 + num2;
Console.WriteLine("Это сумма -> " + result);
result = num1 * num2;
Console.WriteLine("Это произведение -> " + result);

double average = (double)(num1 + num2) / 2;
Console.WriteLine("Среднее арефметическое -> " + average);

Console.ReadKey();