namespace LabByFigure.GeometricFigure
{
    public class Circle : Figure
    {
        private readonly int _radius;

        public double Area => 2 * Math.PI * Math.Sqrt(_radius);

        public Circle(Figure figure, int radius) : base(figure)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверное значение радиуса!");
            _radius = radius;
        }

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
            return new Circle(base.WithColor(color), _radius);
        }

        public override Figure Move(Point coordinates)
        {
            return new Circle(base.Move(coordinates), _radius);
        }

        public override string ToString() => $"{base.ToString()} Круг имеет площадь равную {Area:f3}";

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), _radius);
        }

        public override bool Equals(Figure? other)
        {
            if (other is Circle circle)
                return base.Equals(other) && _radius == circle._radius;
            return false;
        }
    }
}
