using Entities.Entities;

namespace BL.Interfaces
{
    public interface IPlayerService
    {
        string Play();
        Player GetFirstPlayer();
    }
}
