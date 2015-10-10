using BL.Interfaces;

namespace BL
{
    public class PlayerToyService : IPlayerToyService
    {
        public string GetToy(int number)
        {
            return "Porsche " + number;
        }
    }
}