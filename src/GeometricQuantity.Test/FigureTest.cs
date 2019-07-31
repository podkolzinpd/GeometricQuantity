using Xunit;
using GeometricQuantity.Figures;
using System.Collections.Generic;

namespace GeometricQuantity.Test
{
    public class FigureTest
    {
        [Fact]
        public void GetAreaWithoutShapeOfFigure_ShouldReturnCorrectArea()
        {
            // Arrange  
            var expectedValue = 6.0;
            var figures = new List<Figure> { new Circle(3), new Circle(4), new Triangle(3, 4, 5) };

            // Act  
            var area = figures[2].GetArea();

            //Assert  
            Assert.Equal(expectedValue, area);
        }
    }
}