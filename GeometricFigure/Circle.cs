namespace LabByFigure.GeometricFigure
{
    public class Circle : Point
    {
        private readonly int _radius;

        public Circle(string color, GeometricState state, int radius) : base(color, state)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверное значение радиуса!");
            _radius = radius;
        }

        public override Figure EditColor(string color)
        {
            return new Circle(color, _state, _radius);
        }

        public double Area() => 2 * Math.PI * Math.Sqrt(_radius);

        public bool Equals(Circle figure)
        {
            if (figure != null)
                return GetHashCode() == figure.GetHashCode() && _color == figure._color && _radius == figure._radius && _state == figure._state;
            return false;
        }

        public override string ToString() => $"Круг имеет {_color} цвет, {StateFigure()} состояние и площадь равную {Area()}";

        public override int GetHashCode()
        {
            return HashCode.Combine(_color, _state, _radius, GetType);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            return Equals(obj is Circle);
        }
    }
}
