/*
Создать класс Figure для работы с геометрическими фигурами. 
В качестве полей класса задаются цвет фигуры,состояние «видимое/невидимое».
Реализовать операции: передвижение геометрической фигуры по горизонтали,
по вертикали, изменение цвета, опрос состояния (видимый/невидимый).
Метод вывода на экран должен выводить состояние всех полей объекта. 
*/

namespace LabByFigure
{
    public abstract class Figure : IEquatable<Figure>
    {
        protected string Color { get; }
        protected bool Visible { get; }
        protected Point Coordinate { get; }

        public Figure(string color, bool visible) : this(color, visible, new Point(0, 0))
        {
        }

        public Figure(string color, bool visible, Point coordinates)
        {
            Color = color;
            Visible = visible;
            Coordinate = coordinates;
        }

        public abstract Figure WithColor(string color);

        public abstract Figure Move(Point coordinates);

        public override string ToString()
        {
            var сondition = Visible ? "Видимое" : "Не видимое";
            return string.Format("Фигура имеет {0} цвет и {1} состояние и центр в точке{2}.",
                                                                                            Color,
                                                                                            сondition,
                                                                                            Coordinate);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Color, Visible, Coordinate.GetHashCode());
        }

        public override bool Equals(object? obj)
        {
            if (obj is Figure figure)
                return Equals(figure);
            return false;
        }

        public virtual bool Equals(Figure? other)
        {
            return other != null && Color == other.Color && Visible == other.Visible && Coordinate == other.Coordinate;
        }
    }
}
