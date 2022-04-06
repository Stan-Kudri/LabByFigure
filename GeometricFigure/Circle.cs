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

        public override Figure Move(int x, int y)
        {
            return new Circle(_color, _visible, _radius, new Point(_coordinates.X + x, _coordinates.Y + y));
        }

        public override string ToString() => $"Круг имеет {_color} цвет, {GetStateFigure()} состояние и площадь равную {Area:f3}. {_coordinates}";

        public override int GetHashCode()
        {
            return HashCode.Combine(_color, _visible, _radius, _coordinates.GetHashCode());
        }

        public override bool Equals(Figure? other)
        {
            if (other is Circle circle)
                return _color == circle._color && _radius == circle._radius && _visible == circle._visible && _coordinates == circle._coordinates;
            return false;
        }
    }
}
