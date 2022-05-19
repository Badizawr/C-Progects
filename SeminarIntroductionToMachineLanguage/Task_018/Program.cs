// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти:");
int quarterNumber = int.Parse(Console.ReadLine());
string range = "";
if (quarterNumber == 1) range = "x > 0, y > 0";
else if (quarterNumber == 2) range = "x < 0, y > 0";
else if (quarterNumber == 3) range = "x < 0, y < 0";
else if (quarterNumber == 4) range = "x > 0, y < 0";
else Console.WriteLine("Вы ввели некоректное значение");

Console.WriteLine($"Для {quarterNumber} -й четверти координаты точки должны быть в диапазоне {range}");