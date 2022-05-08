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
            int turtleStep = 6;
            for (int i = 0; i < turtleStep; i++)
            {
                Turtle.Move(100);
                Turtle.Turn(60);
            }
        }
    }
}