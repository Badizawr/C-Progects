/* Напишите программу которая на вход два числа и выдаёт,
 какое число больше, а какое меньше.*/

/* решение как в примере
 Console.Write("Введите чило a -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b -> ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = num1 > num2;
Console.Write(result ? "Max = " + num1 : "Max " + num2);
Console.ReadKey();
*/

// которое больше соответствует заданию
Console.Write("Введите первое чило -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число -> ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = num1 > num2;
if (result)
{
    Console.WriteLine("Первое число больше");
    Console.WriteLine("Второе число меньше");
}
else
 {
     Console.WriteLine("Первое число меньше");
     Console.WriteLine("Второе число больше");
 }
 Console.ReadKey();
 