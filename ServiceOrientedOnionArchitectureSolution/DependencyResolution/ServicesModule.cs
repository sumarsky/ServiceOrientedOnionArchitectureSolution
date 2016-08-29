using Ninject.Modules;

using BL.Interfaces;
using BL;

namespace DependencyResolution
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPlayerService>().To<PlayerService>();
            Bind<IPlayerToyService>().To<PlayerToyService>();
            Bind<IPlayerManagementService>().To<PlayerManagementService>();
        }
    }
}
