namespace LabByFigure
{
    public class Point : Figure
    {
        public Point(string color, GeometricState state) : this(color, state, 0, 0)
        {

        }

        public Point(string color, GeometricState state, int x, int y) : base(color, state, x, y)
        {

        }

        public override Figure EditColor(string color)
        {
            return new Point(color, _state, _x, _y);
        }

        public override Figure MovinHorizontally(int x)
        {
            return new Point(_color, _state, _x + x, _y);
        }

        public override Figure MovinVertically(int y)
        {
            return new Point(_color, _state, _x, _y + y);
        }

        public bool Equals(Point figure)
        {
            if (figure != null)
                return GetHashCode() == figure.GetHashCode() && _color == figure._color;
            return false;
        }

        public override string ToString() => $"Точка имеет {_color} цвет и {StateFigure()} состояние. {Coordinates}";

        public override int GetHashCode()
        {
            return HashCode.Combine(_color, _state, GetType);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            return Equals(obj is Point);
        }
    }
}
