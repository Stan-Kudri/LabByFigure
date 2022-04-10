namespace LabByFigure.GeometricFigure
{
    public class Rectangle : Figure, IEquatable<Rectangle>
    {
        private int Width;
        private int Height;

        public Point[] _Vertices => GetVerticesOfPoints();

        public double Area => Width * Height;

        public Rectangle(string color, bool visible, int width, int height) : this(color, visible, width, height, new Point(0, 0))
        {
        }

        public Rectangle(string color, bool visible, int width, int height, Point coordinates) : base(color, visible, coordinates)
        {
            CheckValidSideValue(width, height);
        }

        private void CheckValidSideValue(int width, int height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Неверное значение сторон");
            Width = width;
            Height = height;
        }

        private Point[] GetVerticesOfPoints()
        {
            Point[] vertices = new Point[4];
            var index = 0;
            for (var i = -1; i < 2; i += 2)
            {
                for (var j = -1; j < 2; j += 2)
                {
                    vertices[index] = Coordinates.Move(new Point(i * Width, j * Height));
                    index++;
                }
            }
            return vertices;

        }

        public override Figure WithColor(string color)
        {
            return new Rectangle(color, Visible, Width, Height, Coordinates);
        }

        public override Figure Move(Point coordinates)
        {
            return new Rectangle(Color, Visible, Width, Height, coordinates);
        }

        public override string ToString() => $"{base.ToString()} Прямоугольник имеет площадь равную {Area:f3}";

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Width, Height);
        }
        public override bool Equals(Figure? other)
        {
            return Equals(other as Rectangle);
        }

        public bool Equals(Rectangle? other)
        {
            if (other is Rectangle rectangle)
                return base.Equals(other) && Width == rectangle.Width && Height == rectangle.Height;
            return false;
        }
    }
}
