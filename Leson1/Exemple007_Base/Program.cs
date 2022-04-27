// Зада из первой лекци на нахождении тяжелой гири

int a = 8;
int b = 0;
int c = 10;
int d = 8;
int e = 20;

int max = a;

if (b > max ) max = b;
if (c > max ) max = c;
if (d > max ) max = d;
if (e > max ) max = e;

Console.WriteLine("max = " + max);
