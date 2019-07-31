using Xunit;
using GeometricQuantity.Figures;
using System;

namespace GeometricQuantity.Test
{
    public class GeometricQuantityTest
    {
        [Fact]
        public void ZeroSide_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
        }

        [Fact]
        public void NegativeSide_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
        }

        [Fact]
        public void NotTriangle_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5));
        }

        [Fact]
        public void CheckIsRightTriangle_ShouldReturnTrue()
        {
            // Arrange  
            var expectedValue = true;

            // Act  
            var isRight = new Triangle(3, 4, 5).IsRight();

            //Assert  
            Assert.Equal(expectedValue, isRight);
        }

        [Fact]
        public void CheckIsRightTriangle_ShouldReturnFalse()
        {
            // Arrange  
            var expectedValue = false;

            // Act  
            var isRight = new Triangle(3, 4, 6).IsRight();

            //Assert  
            Assert.Equal(expectedValue, isRight);
        }

        [Fact]
        public void GetTriangleArea_ShouldReturnCorrectArea()
        {
            // Arrange  
            var expectedValue = 5.3327;

            // Act  
            var area = Math.Round(new Triangle(3, 4, 6).GetArea(), 4);

            //Assert  
            Assert.Equal(expectedValue, area);
        }

        [Fact]
        public void GetRightTriangleArea_ShouldReturnCorrectArea()
        {
            // Arrange  
            var expectedValue = 6.0;

            // Act  
            var area = new Triangle(3, 4, 5).GetArea();

            //Assert  
            Assert.Equal(expectedValue, area);
        }
    }
}