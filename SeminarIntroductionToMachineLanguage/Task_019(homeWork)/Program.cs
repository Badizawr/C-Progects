// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число для проверки на палиндром: ");
string text = Console.ReadLine();
int length = text.Length;
bool palindrom = true;

for (int i = 0; i < length / 2; i++)
{
    if (text[i] != text[length - (i + 1)])
    {
        palindrom = false;
        break;
    }
}
if (palindrom)
{
    Console.WriteLine("{0} -> да", text);
}
else
{
    Console.WriteLine("{0} -> нет", text);
}