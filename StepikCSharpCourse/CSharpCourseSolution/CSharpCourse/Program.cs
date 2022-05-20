using System;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            x = x + 1;
            Console.WriteLine(x);
            // инкремент
            x++; //постфиксная запись
            Console.WriteLine(x);

            ++x; //инфиксная запись
            Console.WriteLine(x);
            //декримент
            x = x - 1;
            --x;
            x--;
            Console.WriteLine(x);

            Console.WriteLine("Learn about increments");
            Console.WriteLine($"Last x state is {x}");

            int j = x++; // в этом случае операция присвоения "=" имеет больший приоритет
            Console.WriteLine(j);
            Console.WriteLine(x);

            j = ++x; // прификсный  имеет больший приоритет сначала прибовляем потом назначаем 
            Console.WriteLine(x);
            Console.WriteLine(j);
        }

        static void Overflow()
        {
        checked
            {
            uint x = uint.MaxValue;
            Console.WriteLine(x);

            x = x + 1;
            Console.WriteLine(x);

            x = x - 1;
            Console.WriteLine(x);
            }
        }
        static void VariablesScope()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;

                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                // Console.WriteLine(c); переменная с в незоне видимости
            }
            Console.WriteLine(a);
            //Console.WriteLine(b); переменная в незоне видимости
            //Console.WriteLine(c); переменная в незоне видимости
        }
        static void Literals()
        {
            //бинарные литералы 0b
            int x = 0b11;
            int y = 0b1001;
            int k = 0b10001001;
            int m = 0b1000_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            //шестнадцатиричная система 0х
            x = 0x1F;
            y = 0xFF0D;
            k = 0x1FAB30EF;
            m = 0x1FAB_30EF;
            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine();

            Console.WriteLine(4.5e2); //4.5 * 10^2 = 450
            Console.WriteLine(3.1E-1); //3.1 * 10^-1 = 0.31

            Console.WriteLine();

            //таблица ASCII
            Console.WriteLine('\x78'); //x
            Console.WriteLine('\x66'); //f

            //таблица Unicode
            Console.WriteLine('\u0420'); // P
            Console.WriteLine('\u0421'); // C
        }
        static void Variables()
        {
            int x = -1;

            int y;
            y = 2;

            //int32 x1 = -1;
            //uint z = 1;

            float f = 1.1f;
            double d = 2.3;

            int x2 = 0;
            int x3 = new int();

            var a = 1; //внести переменную не объявляя её
            var b = 1.2;

            // Dictionary<int, string> dict = new Dictionary<int, string>();
            //var dict = new Dictionary<int, string>();
            //var v; так нельзя не указав переменную

            decimal money = 3.0m;

            char character = 'A';
            string name = "John";

            bool canDrive = false;
            bool canDraw = true;

            object obj1 = 1;
            object obj2 = "obj2"; //так не стоит делать

            Console.WriteLine(a);
            Console.WriteLine(name);
        }
    }
}
