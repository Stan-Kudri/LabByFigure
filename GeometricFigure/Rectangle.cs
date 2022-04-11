namespace LabByFigure.GeometricFigure
{
    public class Rectangle : Figure, IEquatable<Rectangle>
    {
        private int width;
        private int height;

        public Point[] Vertices => GetVerticesOfPoints();

        public double Area => width * height;

        public Rectangle(string color, bool visible, int width, int height) : this(color, visible, width, height, new Point(0, 0))
        {
        }

        public Rectangle(string color, bool visible, int width, int height, Point coordinates) : base(color, visible, coordinates)
        {
            CheckValidSideAndSetValue(width, height);
        }

        private void CheckValidSideAndSetValue(int width, int height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Неверное значение сторон");
            this.width = width;
            this.height = height;
        }

        private Point[] GetVerticesOfPoints()
        {
            Point[] vertices = new Point[4];
            var index = 0;
            for (var i = -1; i < 2; i += 2)
            {
                for (var j = -1; j < 2; j += 2)
                {
                    vertices[index] = Coordinate.Move(new Point(i * width, j * height));
                    index++;
                }
            }
            return vertices;

        }

        public override Figure WithColor(string color)
        {
            return new Rectangle(color, Visible, width, height, Coordinate);
        }

        public override Figure Move(Point coordinates)
        {
            return new Rectangle(Color, Visible, width, height, coordinates);
        }

        public override string ToString() => $"{base.ToString()} Прямоугольник имеет площадь равную {Area:f3}";

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), width, height);
        }
        public override bool Equals(Figure? other)
        {
            return Equals(other as Rectangle);
        }

        public bool Equals(Rectangle? other) => other == null ? false : base.Equals(other) && width == other.width && height == other.height;
    }
}
