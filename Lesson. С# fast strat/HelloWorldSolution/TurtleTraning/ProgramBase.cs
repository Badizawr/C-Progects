using Microsoft.SmallBasic.Library;
//Пробуем управлять черепашкой
namespace ConsoleApp7
{
    internal class ProgramBase
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