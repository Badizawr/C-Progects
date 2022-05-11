using System;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
        }
    }
}
