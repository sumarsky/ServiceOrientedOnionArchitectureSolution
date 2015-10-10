using System.Linq;
using BL.Interfaces;
using Data.Interfaces;
using Entities.Entities;

namespace BL
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IPlayerToyService _playerToyService;

        public PlayerService(IPlayerRepository playerRepository, IPlayerToyService playerToyService)
        {
            _playerRepository = playerRepository;
            _playerToyService = playerToyService;
        }

        public string Play()
        {
            return "Play with PlayerService and " + _playerToyService.GetToy(911);
        }

        public Player GetFirstPlayer()
        {
            return _playerRepository.GetAll().FirstOrDefault();
        }
    }
}
