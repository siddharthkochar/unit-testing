using Xunit;

namespace CalculationService.Tests
{
    public class MathematicsTests
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            // Arrange
            int a = 5;
            int b = 10;
            var maths = new Mathematics();

            // Act
            int result = maths.Add(a, b);

            // Assert
            Assert.Equal(15, result);
        }

        [Theory]
        [InlineData(5, 10, 15)]
        [InlineData(-5, -10, -15)]
        [InlineData(int.MaxValue, 1, -2147483648)]
        public void ShouldAddNumbers(int a, int b, int sum)
        {
            // Arrange
            var maths = new Mathematics();

            // Act
            int result = maths.Add(a, b);

            // Assert
            Assert.Equal(sum, result);
        }
    }
}
