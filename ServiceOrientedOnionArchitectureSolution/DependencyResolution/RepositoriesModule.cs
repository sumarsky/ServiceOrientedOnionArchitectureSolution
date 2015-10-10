using Data.Interfaces;
using Data.Repositories;
using Ninject.Modules;

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
