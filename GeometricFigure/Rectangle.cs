namespace LabByFigure.GeometricFigure
{
    public class Rectangle : Figure
    {
        private readonly int _width;
        private readonly int _height;

        public double Area => _width * _height;

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

        public void PrintVertexCoordinat()
        {
            Console.WriteLine("Печать координат вершин прямоугольника:");
            for (var i = -1; i < 2; i += 2)
            {
                for (var j = -1; j < 2; j += 2)
                {
                    Console.WriteLine($"[X = {_coordinates.X + i * _width}; Y = {_coordinates.Y + j * _height}]");
                }
            }
        }

        public override Figure WithColor(string color)
        {
            return new Rectangle(color, _visible, _width, _height, _coordinates);
        }

        public override Figure Move(int x, int y)
        {
            return new Rectangle(_color, _visible, _width, _height, new Point(_coordinates.X + x, _coordinates.Y + y));
        }

        public override string ToString() => $"Прямоугольник имеет {_color} цвет, {GetStateFigure()} состояние и площадь равную {Area}. {_coordinates}";

        public override int GetHashCode()
        {
            return HashCode.Combine(_color, _visible, _width, _height, _coordinates.GetHashCode());
        }
        public override bool Equals(Figure? other)
        {
            if (other is Rectangle rectangle)
                return _color == rectangle._color && _visible == rectangle._visible && _width == rectangle._width && _height == rectangle._height && _coordinates == rectangle._coordinates;
            return false;
        }
    }
}
