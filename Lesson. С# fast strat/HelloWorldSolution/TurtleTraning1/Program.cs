//Пробуем управлять черепашкой
using System;
using Microsoft.SmallBasic.Library;

namespace TurtleTraning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 5;
            int turtleStep = 2;
            for (int i = 0; i < turtleStep; i++)
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