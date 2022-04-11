namespace LabByFigure.GeometricFigure
{
    public class Circle : Figure, IEquatable<Circle>
    {
        private int radius;

        public double Area => 2 * Math.PI * Math.Sqrt(radius);

        public Circle(string color, bool visible, int radius) : this(color, visible, radius, new Point(0, 0))
        {
        }

        public Circle(string color, bool visible, int radius, Point coordinates) : base(color, visible, coordinates)
        {
            CheckValueIsValidAndSet(radius);
        }

        private void CheckValueIsValidAndSet(int radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверное значение радиуса!");
            this.radius = radius;
        }

        public override Figure WithColor(string color)
        {
            return new Circle(color, Visible, radius, Coordinate);
        }

        public override Figure Move(Point coordinates)
        {
            return new Circle(Color, Visible, radius, coordinates);
        }

        public override string ToString() => $"{base.ToString()} Круг имеет площадь равную {Area:f3}";

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), radius);
        }

        public override bool Equals(Figure? other)
        {
            return Equals(other as Circle);
        }

        public bool Equals(Circle? other)
        {
            if (other != null)
                return other is Circle circle ? base.Equals(other) && radius == circle.radius : false;
            return false;
        }
    }
}
