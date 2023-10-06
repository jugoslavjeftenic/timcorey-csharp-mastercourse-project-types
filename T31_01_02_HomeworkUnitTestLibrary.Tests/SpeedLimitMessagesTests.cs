namespace T31_01_02_HomeworkUnitTestLibrary.Tests
{
    public class SpeedLimitMessagesTests
    {
        [Fact]
        public void SpeedLimitShouldReturnSchoolZoneMessage()
        {
            // Arrange
            _ = new SpeedLimitMessages();
            string expected = "You are passing through the school zone.";

            // Act
            string actual = SpeedLimitMessages.SpeedLimit(30);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SpeedLimitShouldReturnCityZoneMessage()
        {
            // Arrange
            _ = new SpeedLimitMessages();
            string expected = "You are passing through the city zone.";

            // Act
            string actual = SpeedLimitMessages.SpeedLimit(50);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SpeedLimitShouldReturnSpeedExceedsMessage()
        {
            // Arrange
            _ = new SpeedLimitMessages();
            string expected = "Your speed exceeds the limit.";

            // Act
            string actual = SpeedLimitMessages.SpeedLimit(150);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, "You are passing through the school zone.")]
        [InlineData(20, "You are passing through the school zone.")]
        [InlineData(30, "You are passing through the school zone.")]
        [InlineData(40, "You are passing through the city zone.")]
        [InlineData(50, "You are passing through the city zone.")]
        [InlineData(60, "You are traveling outside of the city zone.")]
        [InlineData(70, "You are traveling outside of the city zone.")]
        [InlineData(80, "You are traveling outside of the city zone.")]
        [InlineData(90, "You are traveling on the highway.")]
        [InlineData(100, "You are traveling on the highway.")]
        [InlineData(110, "You are traveling on the highway.")]
        [InlineData(120, "You are traveling on the highway.")]
        [InlineData(130, "You are traveling on the highway.")]
        [InlineData(140, "Your speed exceeds the limit.")]
        [InlineData(150, "Your speed exceeds the limit.")]
        public void GreetingShouldReturnExpectedValue(int speedLimit, string expected)
        {
            // Arrange
            _ = new SpeedLimitMessages();

            // Act
            string actual = SpeedLimitMessages.SpeedLimit(speedLimit);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
