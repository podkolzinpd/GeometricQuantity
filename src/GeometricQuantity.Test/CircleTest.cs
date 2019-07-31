using Xunit;
using System;
using GeometricQuantity.Figures;
using System.Collections.Generic;

namespace GeometricQuantity.Test
{
    public class CircleTest
    {
        [Fact]
        public void NegativeRadius_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-3));
        }

        [Fact]
        public void GetCircleArea_ShouldReturnCorrectArea()
        {
            // Arrange  
            var expectedValue = 50.2655;

            // Act  
            var area = Math.Round(new Circle(4).GetArea(), 4);

            //Assert  
            Assert.Equal(expectedValue, area);
        }
    }
}