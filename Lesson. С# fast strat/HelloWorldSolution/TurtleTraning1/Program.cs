//Пробуем управлять черепашкой
using System;
using Microsoft.SmallBasic.Library;

namespace TurtleTraning1
{
    class Program
    {
        static void WriteT(int size) 
        {
            //Начало буквы Т
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(20);
            Turtle.Angle = 90;
            Turtle.Move(40);
            //конец буквы Т
        }

        static void WriteO(int size)
        {
            //Буква О
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }

        static void WriteP(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            for (int i = 0; i < 4; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(size / 2);
            }

        }
        static void Main(string[] args)
        {
            Turtle.Speed = 9;

            // Торт
            Turtle.X = 200;
            Turtle.Y = 200;
            WriteT(60);

            Turtle.X = 220;
            Turtle.Y = 200;
            WriteO(30);

            Turtle.X = 270;
            Turtle.Y = 200;
            WriteP(30);

            Turtle.X = 310;
            Turtle.Y = 200;
            WriteT(30);
            {
                //Рисуем забор
                //Turtle.Move(20);
                //Turtle.TurnRight();
                //Turtle.Move(20);
                //Turtle.TurnRight();
                //Turtle.Move(20);
                //Turtle.TurnLeft();
                //Turtle.Move(20);
                //Turtle.TurnLeft();

                //рисуем ромб
                //Turtle.Move(100);
                //Turtle.Turn(60);
            }
        }
    }
}