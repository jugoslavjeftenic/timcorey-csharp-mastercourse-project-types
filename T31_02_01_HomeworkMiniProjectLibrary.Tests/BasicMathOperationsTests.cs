namespace T31_02_01_HomeworkMiniProjectLibrary.Tests
{
    public class BasicMathOperationsTests
    {
        [Fact]
        public void AddShouldReturn4()
        {
            // Arrange
            _ = new BasicMathOperations();
            double expected = 4;

            // Act
            double actual = BasicMathOperations.Add(2, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, 3, 2)]
        [InlineData(2.2, 3.3, 5.5)]
        [InlineData(0, 5.1, 5.1)]
        [InlineData(-100, -3, -103)]
        [InlineData(0, 0, 0)]
        public void AddShouldReturnExpectedValue(double a, double b, double expected)
        {
            // Arrange
            _ = new BasicMathOperations();

            // Act
            double actual = BasicMathOperations.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(5.5, 3.3, 2.2)]
        [InlineData(0, 5.1, -5.1)]
        [InlineData(-100, -3, -97)]
        [InlineData(0, 0, 0)]
        public void SubtractShouldReturnExpectedValue(double a, double b, double expected)
        {
            // Arrange
            _ = new BasicMathOperations();

            // Act
            double actual = BasicMathOperations.Subtract(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2.2, 3.3, 7.26)]
        [InlineData(0, 5.1, 0)]
        [InlineData(-10, -3, 30)]
        [InlineData(0, 0, 0)]
        public void MultiplyShouldReturnExpectedValue(double a, double b, double expected)
        {
            // Arrange
            _ = new BasicMathOperations();

            // Act
            double actual = BasicMathOperations.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(3.3, 2.2, 1.4999999999999998)]
        [InlineData(0, 5.1, 0)]
        [InlineData(-3, -1, 3)]
        [InlineData(0, 0, double.NaN)]
        public void DivideShouldReturnExpectedValue(double a, double b, double expected)
        {
            // Arrange
            _ = new BasicMathOperations();

            // Act
            double actual = BasicMathOperations.Divide(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
