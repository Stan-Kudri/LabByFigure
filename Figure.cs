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
        protected readonly string _color;
        protected readonly bool _visible;
        protected readonly Point _coordinates;

        public Figure(string color, bool visible) : this(color, visible, new Point(0, 0))
        {
        }

        protected Figure(string color, bool visible, Point coordinates)
        {
            _color = color;
            _visible = visible;
            _coordinates = coordinates;
        }

        public abstract Figure WithColor(string color);

        public abstract Figure Move(int x, int y);

        protected string GetStateFigure() => !_visible ? "Не видимое" : "Видимое";

        public override string ToString() => $"Фигура имеет {_color} цвет и {GetStateFigure()} состояние. {_coordinates}";

        public override int GetHashCode()
        {
            return HashCode.Combine(_color, _visible, _coordinates.GetHashCode());
        }

        public override bool Equals(object? obj)
        {
            if (obj is Figure figure)
                return Equals(figure);
            return false;
        }

        public abstract bool Equals(Figure? other);
    }
}
