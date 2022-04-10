namespace LabByFigure.GeometricFigure
{
    public class Circle : Figure, IEquatable<Circle>
    {
        private int Radius;

        public double Area => 2 * Math.PI * Math.Sqrt(Radius);

        public Circle(string color, bool visible, int radius) : this(color, visible, radius, new Point(0, 0))
        {
        }

        public Circle(string color, bool visible, int radius, Point coordinates) : base(color, visible, coordinates)
        {
            CheckValidSideValue(radius);
        }

        private void CheckValidSideValue(int radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверное значение радиуса!");
            Radius = radius;
        }

        public override Figure WithColor(string color)
        {
            return new Circle(color, Visible, Radius, Coordinates);
        }

        public override Figure Move(Point coordinates)
        {
            return new Circle(Color, Visible, Radius, coordinates);
        }

        public override string ToString() => $"{base.ToString()} Круг имеет площадь равную {Area:f3}";

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Radius);
        }

        public override bool Equals(Figure? other)
        {
            return Equals(other as Circle);
        }

        public bool Equals(Circle? other)
        {
            if (other is Circle circle)
                return base.Equals(other) && Radius == circle.Radius;
            return false;
        }
    }
}
