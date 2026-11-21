using fortumakov.enums;
using System.Drawing;

namespace fortumakov.classes
{
    public class PointMy : FigureBase
    {
        protected double X, Y;

        public PointMy(double x, double y, Color color, Condition condition)
        {
            X = x;
            Y = y;
            Color = color;
            Condition = condition;
        }
        
        public override void MoveHorizontal(double dy)
        {
            Y += dy;
        }

        public override void MoveVertical(double dx)
        {
            X += dx;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Координаты: {X}, {Y}\n");
        }
    }
}
