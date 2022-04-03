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
            Console.WriteLine($"[X = {_coordinates.X - _width}; Y = {_coordinates.Y + _height}]");
            Console.WriteLine($"[X = {_coordinates.X - _width}; Y = {_coordinates.Y - _height}]");
            Console.WriteLine($"[X = {_coordinates.X + _width}; Y = {_coordinates.Y - _height}]");
            Console.WriteLine($"[X = {_coordinates.X + _width}; Y = {_coordinates.Y + _height}]");
        }

        public override Figure WithColor(string color)
        {
            return new Rectangle(color, _visible, _width, _height, _coordinates);
        }

        public override Figure MoveHorizontally(int x)
        {
            return new Rectangle(_color, _visible, _width, _height, new Point(_coordinates.X + x, _coordinates.Y));
        }

        public override Figure MoveVertically(int y)
        {
            return new Rectangle(_color, _visible, _width, _height, new Point(_coordinates.X, _coordinates.Y + y));
        }

        public bool Equals(Rectangle figure)
        {
            if (figure != null)
                return _color == figure._color && _visible == figure._visible && _width == figure._width && _height == figure._height && _coordinates == figure._coordinates && GetHashCode() == figure.GetHashCode();
            return false;
        }

        public override string ToString() => $"Прямоугольник имеет {_color} цвет, {StateFigure} состояние и площадь равную {Area}. {_coordinates}";

        public override int GetHashCode()
        {
            return HashCode.Combine(_color, _visible, _width, _height, _coordinates.GetHashCode(), GetType());
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(Rectangle))
                return false;
            return Equals(obj is Rectangle);
        }
    }
}
