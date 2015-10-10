using System;
using BL;
using BL.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ServiceOrientedOnionArchitectureSolution.UnitTests
{
    [TestClass]
    public class PlayerServiceTest
    {
        private PlayerService _playerService;
        private Mock<IPlayerToyService> _playerToyServiceMock;

        [TestInitialize]
        public void Initialize()
        {
            _playerToyServiceMock = new Mock<IPlayerToyService>();

            _playerService = new PlayerService(_playerToyServiceMock.Object);

            _playerToyServiceMock.Setup(x => x.GetToy(It.IsAny<int>()))
                .Returns("_playerToyServiceMock");
        }

        [TestMethod]
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
