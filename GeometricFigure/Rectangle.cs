﻿namespace LabByFigure.GeometricFigure
{
    public class Rectangle : Point
    {
        private readonly int _width;
        private readonly int _height;

        public Rectangle(string color, GeometricState state, int width, int height) : base(color, state)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Неверное значение сторон");
            _width = width;
            _height = height;
        }

        public override Figure EditColor(string color)
        {
            return new Rectangle(color, _state, _width, _height);
        }

        public double Area() => _width * _height;

        public bool Equals(Rectangle figure)
        {
            if (figure != null)
                return GetHashCode() == figure.GetHashCode() && _color == figure._color && _state == figure._state && _width == figure._width && _height == figure._height;
            return false;
        }

        public override string ToString() => $"Прямоугольник имеет {_color} цвет, {StateFigure()} состояние и площадь равную {Area()}";

        public override int GetHashCode()
        {
            return HashCode.Combine(_color, _state, _width, _height, GetType);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            return Equals(obj is Rectangle);
        }
    }
}
