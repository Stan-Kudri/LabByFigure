namespace LabByFigure.GeometricFigure
{
    public class Circle : Figure, IEquatable<Circle>
    {
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Неверное значение радиуса!");
                _radius = value;
            }
        }

        public double Area => 2 * Math.PI * Math.Sqrt(_radius);

        public Circle(string color, bool visible, int radius) : this(color, visible, radius, new Point(0, 0))
        {
        }

        public Circle(string color, bool visible, int radius, Point coordinates) : base(color, visible, coordinates)
        {
            _radius = radius;
        }

        public override Figure WithColor(string color)
        {
            return new Circle(color, Visible, _radius, Coordinate);
        }

        public override Figure Move(Point coordinates)
        {
            return new Circle(Color, Visible, _radius, coordinates);
        }

        public override string ToString() => $"{base.ToString()} Круг имеет площадь равную {Area:f3}";

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), _radius);
        }

        public override bool Equals(Figure? other)
        {
            return Equals(other as Circle);
        }

        public bool Equals(Circle? other) => other != null && base.Equals(other) && _radius == other._radius;
    }
}
