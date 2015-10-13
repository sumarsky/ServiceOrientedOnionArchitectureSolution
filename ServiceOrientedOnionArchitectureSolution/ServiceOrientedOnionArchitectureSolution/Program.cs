using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BL.Interfaces;
using DependencyResolution;
using Ninject;
using Ninject.Modules;

namespace ServiceOrientedOnionArchitectureSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = CreateKernel();
            
            var player = kernel.Get<IPlayerService>();
            Console.WriteLine(player.Play());
        }

        public static IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            var modules = new List<INinjectModule>
            {
                new RepositoriesModule(),
                new ServicesModule()
            };

            kernel.Load(modules);
            return kernel;
        }
    }
}
