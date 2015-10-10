using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;
using Data.Repositories.Base;
using Entities.Entities;

namespace Data.Repositories
{
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(MyDbContext myDbContext)
            : base(myDbContext)
        {
        }
    }
}
