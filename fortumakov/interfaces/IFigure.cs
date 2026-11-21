using System.Drawing;

namespace fortumakov.interfaces
{
    public interface IFigure
    {
        void MoveVertical(double dx);
        void MoveHorizontal(double dy);
        void ColorChange(Color color);
        void PrintInfo();

    }
}
