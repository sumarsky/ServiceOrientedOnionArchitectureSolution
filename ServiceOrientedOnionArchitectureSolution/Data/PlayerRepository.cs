using Entities;
using Data.Interfaces;
using Data.Base;

namespace Data
{
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(MyDbContext myDbContext)
            : base(myDbContext)
        {
        }
    }
}
