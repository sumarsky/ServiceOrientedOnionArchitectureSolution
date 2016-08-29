using System.Linq;

using Entities;
using Data.Interfaces;
using BL.Base;
using BL.Interfaces;

namespace BL
{
    public class PlayerManagementService : BaseManagementService<Player, IPlayerRepository>, IPlayerManagementService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerManagementService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public override IPlayerRepository Repository
        {
            get { return _playerRepository; }
        }

        public Player GetFirstPlayer()
        {
            return _playerRepository.GetAll().FirstOrDefault();
        }
    }
}
