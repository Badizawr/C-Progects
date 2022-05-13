// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

/*Console.Write("Enter number :");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0) Console.WriteLine("да");
else Console.WriteLine("Нет");*/

Console.Write("Enter number A :");
int a = int.Parse(Console.ReadLine());
bool res = a % 7 == 0 && a % 23 == 0;
Console.WriteLine(res ? "Yes" : "No");

Console.Write("Enter number A :");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter number B :");
int b = int.Parse(Console.ReadLine());
bool res = b == a * a || a == b * b;
Console.WriteLine(res ? "Да" : "Нет");
