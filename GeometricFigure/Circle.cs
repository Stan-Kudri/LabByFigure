namespace LabByFigure.GeometricFigure
{
    public class Circle : Figure
    {
        private readonly int _radius;

        public double Area => 2 * Math.PI * Math.Sqrt(_radius);

        public Circle(string color, bool visible, int radius) : this(color, visible, radius, new Point(0, 0))
        {
        }

        public Circle(string color, bool visible, int radius, Point coordinates) : base(color, visible, coordinates)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверное значение радиуса!");
            _radius = radius;
        }

        public override Figure WithColor(string color)
        {
            return new Circle(color, _visible, _radius, _coordinates);
        }

        public override Figure MoveHorizontally(int x)
        {
            return new Circle(_color, _visible, _radius, new Point(_coordinates.X + x, _coordinates.Y));
        }

        public override Figure MoveVertically(int y)
        {
            return new Circle(_color, _visible, _radius, new Point(_coordinates.X, _coordinates.Y + y));
        }

        public bool Equals(Circle figure)
        {
            if (figure == null)
                return false;
            return _color == figure._color && _radius == figure._radius && _visible == figure._visible && _coordinates == figure._coordinates && GetHashCode() == figure.GetHashCode();
        }

        public override string ToString() => $"Круг имеет {_color} цвет, {StateFigure} состояние и площадь равную {Area:f3}. {_coordinates}";

        public override int GetHashCode()
        {
            return HashCode.Combine(_color, _visible, _radius, _coordinates.GetHashCode(), GetType());
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(Circle))
                return false;
            return Equals(obj is Circle);
        }
    }
}
