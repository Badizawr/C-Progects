// Напишите программу, которая на вход принимает число и выдаёт,
// Является ли число чётным (делится ли оно на 2 без остатка)

Console.Write("Введите число -> ");
int num = int.Parse(Console.ReadLine());
bool result = num % 2 == 0;
Console.Write(result ? "Число чётное" : "Число не Чётное");
Console.ReadKey()

/* через if else

Console.Write("Введите число -> ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0  )
{
    Console.Write("Число чётное");
}
else Console.Write("Число не чётное");
Console.ReadKey();*/