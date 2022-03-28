namespace LabByFigure
{
    public class Point : Figure
    {
        public Point(string color, GeometricState state) : base(color, state)
        {

        }

        public override Figure EditColor(string color)
        {
            return new Point(color, _state);
        }

        public bool Equals(Point figure)
        {
            if (figure != null)
                return GetHashCode() == figure.GetHashCode() && _color == figure._color;
            return false;
        }

        public override string ToString() => $"Точка имеет {_color} цвет и {StateFigure()} состояние";

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
