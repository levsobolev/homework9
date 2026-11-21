using fortumakov.classes;
using fortumakov.enums;
using System.Drawing;

namespace fortumakov
{
    public class Program
    {
        public static void Task101()
        {
            Console.WriteLine("Упражнение 10.1. Создать интерфейс ICipher, который определяет методы поддержки\r\n" +
                "шифрования строк. В интерфейсе объявляются два метода encode() и decode(), которые\r\n" +
                "используются для шифрования и дешифрования строк, соответственно. Создать класс\r\n" +
                "ACipher, реализующий интерфейс ICipher. Класс шифрует строку посредством сдвига\r\n" +
                "каждого символа на одну «алфавитную» позицию выше. Например, в результате такого\r\n" +
                "сдвига буква А становится буквой Б. Создать класс BCipher, реализующий интерфейс\r\n" +
                "ICipher. Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й\r\n" +
                "позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца\r\n" +
                "алфавита. Например, буква В заменяется на букву Э. Написать программу,\r\nдемонстрирующую функционирование классов.");

            ACipher aCipher = new ACipher();

            Console.WriteLine(aCipher.encode("баран"));

            Console.WriteLine(aCipher.decode("вбсбо"));

            BCipher bCipher = new BCipher();

            Console.WriteLine(bCipher.encode("баран"));

            Console.WriteLine(bCipher.encode("юяояс"));
        }

        public static void TaskHome101()
        {
            Console.WriteLine("Домашнее задание 10.1. Создать класс Figure для работы с геометрическими фигурами. В\r\n" +
                "качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». Реализовать\r\n" +
                "операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение\r\n" +
                "цвета, опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить\r\n" +
                "состояние всех полей объекта. Создать класс Point (точка) как потомок геометрической\r\n" +
                "фигуры. Создать класс Circle (окружность) как потомок точки. В класс Circle добавить\r\n" +
                "метод, который вычисляет площадь окружности. Создать класс Rectangle (прямоугольник)\r\n" +
                "как потомок точки, реализовать метод вычисления площади прямоугольника. Точка,\r\n" +
                "окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и\r\n" +
                "вертикали, изменения цвета. Подумать, какие методы можно объявить в интерфейсе,\r\n" +
                "нужно ли объявлять абстрактный класс, какие методы и поля будут в абстрактном классе,\r\nкакие\r\n" +
                "методы будут виртуальными, какие перегруженными.");

            PointMy point = new(2, 3, Color.Red, Condition.Видимое);
            Circle circle = new(0, 0, Color.Blue , Condition.Видимое, 5);
            RectangleMy rect = new(1, 1, Color.Green, Condition.Невидимое, 4, 6);

            point.PrintInfo();
            Console.WriteLine(point.IsCondition());
            Console.WriteLine();

            circle.MoveHorizontal(10);
            circle.MoveVertical(-4);
            circle.ColorChange(Color.Yellow);
            circle.PrintInfo();
            Console.WriteLine(circle.IsCondition());
            Console.WriteLine();

            Console.WriteLine(rect.IsCondition());
            rect.ColorChange(Color.Violet);
            rect.PrintInfo();

        }
        public static void Main(string[] args)
        {
            Task101();
            TaskHome101();
        }
    }
}

