using System;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
          GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
          Turtle.PenUp();

          GraphicsWindow.BrushColor = "blue";
          var eat = Shapes.AddRectangle(10, 10);
          Shapes.Move(eat, 200, 200);

          while(true)
            {
                Turtle.Move(10);
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if(GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if(GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if(GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
            else if(GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }

        }
    }
}
