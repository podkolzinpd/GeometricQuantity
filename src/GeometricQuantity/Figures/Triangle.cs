using System;

namespace GeometricQuantity.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        int _a;
        int _b;
        int _c;

        public Triangle(int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0)
                throw new ArgumentException("Сторона не может быть равна 0");

            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Сторона не может принимать отрицательное значение");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Стороны не образуют треугольник");

            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            if (IsRight())
                return _a * _b / 2;

            return 0.25 * Math.Sqrt((_a + _b - _c) * (_a - _b + _c) *
                (-_a + _b + _c) * (_a + _b + _c));
        }

        /// <summary>
        /// Проверка: является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            return _c * _c == _a * _a + _b * _b;
        }
    }
}