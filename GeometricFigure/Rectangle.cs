namespace LabByFigure.GeometricFigure
{
    public class Rectangle : Figure
    {
        private readonly int _width;
        private readonly int _height;

        public double Area => _width * _height;

        public Rectangle(Figure figure, int width, int height) : base(figure)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Неверное значение сторон");
            _width = width;
            _height = height;
        }

        public Rectangle(string color, bool visible, int width, int height) : this(color, visible, width, height, new Point(0, 0))
        {
        }

        public Rectangle(string color, bool visible, int width, int height, Point coordinates) : base(color, visible, coordinates)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Неверное значение сторон");
            _width = width;
            _height = height;
        }

        /*public void PrintVertexCoordinat()
        {
            Console.WriteLine("Печать координат вершин прямоугольника:");
            for (var i = -1; i < 2; i += 2)
            {
                for (var j = -1; j < 2; j += 2)
                {
                    Console.WriteLine($"[X = {_coordinates.X + i * _width}; Y = {_coordinates.Y + j * _height}]");
                }
            }
        }*/

        public override Figure WithColor(string color)
        {
            return new Rectangle(base.WithColor(color), _width, _height);
        }

        public override Figure Move(Point coordinates)
        {
            return new Rectangle(base.Move(coordinates), _width, _height);
        }

        public override string ToString() => $"{base.ToString()} Прямоугольник имеет площадь равную {Area:f3}";

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), _width, _height);
        }
        public override bool Equals(Figure? other)
        {
            if (other is Rectangle rectangle)
                return base.Equals(other) && _width == rectangle._width && _height == rectangle._height;
            return false;
        }
    }
}
