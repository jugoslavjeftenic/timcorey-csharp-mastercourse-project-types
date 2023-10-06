namespace T31_01_01_UnitTestLibrary.Tests
{
    // Arrange, Act, Assert
    // "expected"  "actual"
    // Red, Green, Refactor

    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange
            DisplayMessages messages = new();
            string expected = "Go to bed Tim.";

            // Act
            string actual = DisplayMessages.Greetings("Tim", 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessages messages = new();
            string expected = "Good afternoon Tim.";

            // Act
            string actual = DisplayMessages.Greetings("Tim", 14);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Tim", 0, "Go to bed Tim.")]
        [InlineData("Tim", 1, "Go to bed Tim.")]
        [InlineData("Tim", 2, "Go to bed Tim.")]
        [InlineData("Tim", 3, "Go to bed Tim.")]
        [InlineData("Tim", 4, "Go to bed Tim.")]
        [InlineData("Tim", 5, "Good morning Tim.")]
        [InlineData("Tim", 6, "Good morning Tim.")]
        [InlineData("Tim", 7, "Good morning Tim.")]
        [InlineData("Tim", 8, "Good morning Tim.")]
        [InlineData("Tim", 9, "Good morning Tim.")]
        [InlineData("Tim", 10, "Good morning Tim.")]
        [InlineData("Tim", 11, "Good morning Tim.")]
        [InlineData("Tim", 12, "Good afternoon Tim.")]
        [InlineData("Tim", 13, "Good afternoon Tim.")]
        [InlineData("Tim", 14, "Good afternoon Tim.")]
        [InlineData("Tim", 15, "Good afternoon Tim.")]
        [InlineData("Tim", 16, "Good afternoon Tim.")]
        [InlineData("Tim", 17, "Good afternoon Tim.")]
        [InlineData("Tim", 18, "Good evning Tim.")]
        [InlineData("Tim", 19, "Good evning Tim.")]
        [InlineData("Tim", 20, "Good evning Tim.")]
        [InlineData("Tim", 21, "Good evning Tim.")]
        [InlineData("Tim", 22, "Good evning Tim.")]
        [InlineData("Tim", 23, "Good evning Tim.")]

        public void GreetingShouldReturnExpectedValue(string firstName, int hourOfTheDay, string expected)
        {
            // Arrange
            DisplayMessages messages = new();

            // Act
            string actual = DisplayMessages.Greetings(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
