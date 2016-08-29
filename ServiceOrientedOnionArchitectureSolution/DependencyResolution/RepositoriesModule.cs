using Ninject.Modules;

using Data.Interfaces;
using Data;

namespace DependencyResolution
{
    public class RepositoriesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPlayerRepository>().To<PlayerRepository>();
        }
    }
}
