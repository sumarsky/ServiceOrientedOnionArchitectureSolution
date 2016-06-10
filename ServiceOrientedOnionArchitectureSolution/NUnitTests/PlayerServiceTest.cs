using BL;
using BL.Interfaces;
using Moq;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class PlayerServiceTest
    {
        private PlayerService _playerService;
        private Mock<IPlayerToyService> _playerToyServiceMock;

        [TestFixtureSetUp]
        public void Initialize()
        {
            _playerToyServiceMock = new Mock<IPlayerToyService>();

            _playerService = new PlayerService(_playerToyServiceMock.Object);

            _playerToyServiceMock.Setup(x => x.GetToy(It.IsAny<int>()))
                .Returns("_playerToyServiceMock");
        }

        [Test]
        public void Play_Default_ReturnSentence()
        {
            // Arrange
            string expected = "Play with PlayerService and _playerToyServiceMock";

            // Act
            var result = _playerService.Play();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
