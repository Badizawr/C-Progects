// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

double a = InputNumbersDouble("Введите A: ");
double b = InputNumbersDouble("Введите В: ");

double result = Degree(a, b); 
Console.WriteLine($"Результат -> {result}");

double Degree(double a, double b)
{
  
  if (b > 1) return a * Degree(a, b-1);
  return a;
}

double InputNumbersDouble(string input) 
{
  Console.Write(input);
  double output = Convert.ToDouble(Console.ReadLine());
  return output;
}
