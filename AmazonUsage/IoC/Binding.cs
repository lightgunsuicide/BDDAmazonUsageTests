using Dependencies.Interfaces;
using Framework.PageClasses;
using Ninject.Modules;

namespace BDD.IoC
{
    public class Binding : NinjectModule
    {
        public override void Load() => Bind<IHomePage>().To<HomePage>();
    }
}
