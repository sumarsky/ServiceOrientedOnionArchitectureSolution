using BL.Interfaces;

namespace BL
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerToyService _playerToyService;

        public PlayerService(IPlayerToyService playerToyService)
        {
            _playerToyService = playerToyService;
        }

        public string Play()
        {
            return "Play with PlayerService and " + _playerToyService.GetToy(911);
        }
    }
}
