/*
Создать класс Figure для работы с геометрическими фигурами. 
В качестве полей класса задаются цвет фигуры,состояние «видимое/невидимое».
Реализовать операции: передвижение геометрической фигуры по горизонтали,
по вертикали, изменение цвета, опрос состояния (видимый/невидимый).
Метод вывода на экран должен выводить состояние всех полей объекта. 
*/

namespace LabByFigure
{
    public abstract class Figure
    {
        protected readonly string _color;
        protected readonly GeometricState _state;
        protected readonly int _x;
        protected readonly int _y;

        protected string Coordinates => $"Координаты по вертикали: {_x}; по горизонтали {_y}";

        public Figure(string color, GeometricState state) : this(color, state, 0, 0)
        {
        }

        protected Figure(string color, GeometricState state, int x, int y)
        {
            _color = color;
            _state = state;
            _x = x;
            _y = y;
        }


        public abstract Figure EditColor(string color);

        public bool VisibleState => _state == GeometricState.Visible;

        public abstract Figure MovinHorizontally(int x);

        public abstract Figure MovinVertically(int y);

        protected string StateFigure()
        {
            if (_state == GeometricState.Invisible)
                return "Не видимое";
            else if (_state == GeometricState.Visible)
                return "Видимое";
            return string.Empty;
        }

        public bool Equals(Figure figure)
        {
            if (figure != null)
                return GetHashCode() == figure.GetHashCode() && _color == figure._color;
            return false;
        }

        public override string ToString() => $"Фигура имеет {_color} цвет и {StateFigure()} состояние. {Coordinates}";

        public override int GetHashCode()
        {
            return HashCode.Combine(_color, _state, GetType);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            return Equals(obj is Figure);
        }
    }
}
