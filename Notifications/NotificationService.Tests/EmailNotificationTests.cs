using Moq;
using NotificationService.Abstractions;
using NotificationService.Implementations;
using Xunit;

namespace NotificationService.Tests
{
    public class EmailNotificationTests
    {
        [Fact]
        public void ShouldFailToNotifyViaEmail()
        {
            // Arrange
            var mockUser = new Mock<IUser>();
            mockUser.Setup(x => x.Email).Returns(string.Empty);
            mockUser.Setup(x => x.Name).Returns("JohnWatson");

            var mockLogger = new Mock<ILogger>();
            mockLogger.Setup(x => x.Log(It.IsAny<string>())).Verifiable();
            
            INotificationService service = new Email(mockUser.Object, mockLogger.Object);

            //Act
            bool isNotified = service.Notify();

            // Assert
            Assert.False(isNotified);
            mockLogger.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
        }
    }
}
