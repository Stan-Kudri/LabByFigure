namespace LabByFigure.GeometricFigure
{
    public class Rectangle : Figure, IEquatable<Rectangle>
    {
        private int _width;
        private int _height;

        public int Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Неверное значение сторон");
                _width = value;
            }
        }

        public int Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Неверное значение сторон");
                _height = value;
            }
        }

        public Point[] Vertices => GetVerticesOfPoints();

        public double Area => _width * _height;

        public Rectangle(string color, bool visible, int width, int height) : this(color, visible, width, height, new Point(0, 0))
        {
        }

        public Rectangle(string color, bool visible, int width, int height, Point coordinates) : base(color, visible, coordinates)
        {
            _width = width;
            _height = height;
        }

        private Point[] GetVerticesOfPoints()
        {
            Point[] vertices = new Point[4];
            var index = 0;
            for (var i = -1; i < 2; i += 2)
            {
                for (var j = -1; j < 2; j += 2)
                {
                    vertices[index] = Coordinate.Move(new Point(i * _width, j * _height));
                    index++;
                }
            }
            return vertices;
        }

        public override Figure WithColor(string color)
        {
            return new Rectangle(color, Visible, _width, _height, Coordinate);
        }

        public override Figure Move(Point coordinates)
        {
            return new Rectangle(Color, Visible, _width, _height, coordinates);
        }

        public override string ToString() => $"{base.ToString()} Прямоугольник имеет площадь равную {Area:f3}";

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), _width, _height);
        }
        public override bool Equals(Figure? other)
        {
            return Equals(other as Rectangle);
        }

        public bool Equals(Rectangle? other) => other != null && base.Equals(other) && _width == other._width && _height == other._height;
    }
}
