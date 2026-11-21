using fortumakov.enums;

namespace fortumakov.classes
{
    public class Circle : PointMy
    {
        protected readonly double Radius;

        public Circle(double x, double y, System.Drawing.Color color, Condition condition, double radius) : base(x, y, color, condition)
        {
            if (radius <= 0)
            {
                Radius = 1;
            }
            else
            {
                Radius = radius;
            }
        }

        public double GetArea()
        {
            return Radius * Math.PI * Radius;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Радиус - {Radius}\nПлощадь - {GetArea()}");
        }
    }
}
