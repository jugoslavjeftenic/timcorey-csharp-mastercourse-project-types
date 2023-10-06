namespace T31_02_02_SolutionMiniProjectLibrary.Tests
{
    public class CalculationsTests
    {
        [Theory]
        [InlineData(4, 2, 6)]
        [InlineData(0, 0, 0)]
        [InlineData(1234, -1234, 0)]
        public void AddShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arange
            Calculations calc = new();

            // Act
            double actual = calc.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 2, 6)]
        [InlineData(0, -2, 2)]
        [InlineData(9, -2, 11)]
        public void SubstractShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arange
            Calculations calc = new();

            // Act
            double actual = calc.Substract(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(40, 0, 0)]
        [InlineData(9, 9, 81)]
        public void MultiplyShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arange
            Calculations calc = new();

            // Act
            double actual = calc.Multiply(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(1, 4, 0.25)]
        [InlineData(6, 2, 3)]
        [InlineData(15, 0, 0)]
        public void DivideShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arange
            Calculations calc = new();

            // Act
            double actual = calc.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
