namespace LabByFigure
{
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point system)
        {
            return X == system.X && Y == system.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            return Equals(obj is Point);
        }

        public override string ToString()
        {
            return $"Координаты центра фигуры по вертикали: {X}; по горизонтали {Y}";
        }
    }
}
