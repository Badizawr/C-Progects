// Напишите программу которая на ввод принимает одно число (N)
//а на выводе показывает все числа от -N до N
Console.Write("Введите целое число -> ");
int N = int.Parse(Console.ReadLine());
int Y = -N;
while(Y <= N)
{
    Console.WriteLine(Y);
    Y++;
}