/*
Создать класс Figure для работы с геометрическими фигурами. 
В качестве полей класса задаются цвет фигуры,состояние «видимое/невидимое».
Реализовать операции: передвижение геометрической фигуры по горизонтали,
по вертикали, изменение цвета, опрос состояния (видимый/невидимый).
Метод вывода на экран должен выводить состояние всех полей объекта. 
*/

namespace LabByFigure
{
    public class Figure
    {
        private readonly string _color;
        private readonly bool _visible;
        private readonly Point _coordinates;



        public Figure(Figure figure)
        {
            _color = figure._color;
            _visible = figure._visible;
            _coordinates = figure._coordinates;
        }

        public Figure(string color, bool visible) : this(color, visible, new Point(0, 0))
        {
        }

        protected Figure(string color, bool visible, Point coordinates)
        {
            _color = color;
            _visible = visible;
            _coordinates = coordinates;
        }

        public virtual Figure WithColor(string color)
        {
            return new Figure(color, _visible, _coordinates);
        }

        public virtual Figure Move(Point coordinates)
        {
            return new Figure(_color, _visible, _coordinates.Move(coordinates));
        }

        protected string GetStateFigure() => !_visible ? "Не видимое" : "Видимое";

        public override string ToString() => $"Фигура имеет {_color} цвет и {GetStateFigure()} состояние и центр в точке{_coordinates}.";

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

        public virtual bool Equals(Figure? other)
        {
            if (other is Figure figure)
                return _color == figure._color && _visible == figure._visible && _coordinates == figure._coordinates;
            return false;
        }
    }
}
