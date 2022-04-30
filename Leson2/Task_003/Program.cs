// напишите программу которая будет выдавать название недели по заданному номеру

Console.Write("Введите номер ->");
string dayWeek = Console.ReadLine();
if (dayWeek == "1") Console.Write("Понедельник");
else if (dayWeek == "2") Console.Write("Вторник");
else if (dayWeek == "3") Console.Write("Среда");
else if (dayWeek == "4") Console.Write("Четверг");
else if (dayWeek == "5") Console.Write("Пятница");
else if (dayWeek == "6") Console.Write("Суббота");
else if (dayWeek == "7") Console.Write("Воскресенье");
else Console.Write("Ошибка ввода");

Console.ReadKey();