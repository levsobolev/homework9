using fortumakov.enums;
using System.Drawing;

namespace fortumakov.classes
{
    public class RectangleMy : PointMy
    {
        protected readonly double Height;
        protected readonly double Width;

        public RectangleMy(double x, double y, Color color, Condition condition, double height, double width) : base(x, y, color, condition)
        {
            Height = height;
            Width = width;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Высота - {Height}\nДлина - {Width}\nПлощадь - {GetArea()}");
        }
    }
}
