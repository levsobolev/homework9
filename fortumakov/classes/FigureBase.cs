using fortumakov.enums;
using fortumakov.interfaces;
using System.Drawing;

namespace fortumakov.classes
{
    public abstract class FigureBase : IFigure
    {
        public Color Color { get; set; }
        public Condition Condition { get; set; }

        public abstract void MoveVertical(double dx);
        public abstract void MoveHorizontal(double dy);
        public void ColorChange(Color color)
        {
            Color = color;
        }
        public Condition IsCondition()
        {
            return Condition;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Цвет - {Color},\n Состояние - {Condition}\n");
        }
    }
}
