using System;

namespace GeometricQuantity.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        int _radius;

        public Circle(int radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус круга не может принимать отрицательное значение");

            _radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}