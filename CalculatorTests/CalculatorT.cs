using System;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorT
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 5.25, 6.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            //Arrange

            //Act
            double actual = Calculator.Add(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(10.5, 2, 5.25)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            //Arrange

            //Act
            double actual = Calculator.Divide(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Divide_DivideByZero()
        {
            //Arrange
            double expected = 0;
            //Act
            double actual = Calculator.Divide(15, 0);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
