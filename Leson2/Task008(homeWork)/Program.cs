// напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до (N)

Console.Write("Введите целое число -> ");
int N = int.Parse(Console.ReadLine());
int i = 0;
while(i < N)
{
i +=2;
Console.Write(i +" ");
}
Console.ReadKey();