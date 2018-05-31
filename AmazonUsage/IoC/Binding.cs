using Dependencies.Interfaces;
using Framework.PageClasses;
using Ninject.Modules;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BDD.IoC
{
    public class Binding : NinjectModule
    {
        public override void Load() {
            Bind<IWebDriver>().To<ChromeDriver>();
            Bind<IHomePage>().To<HomePage>();            
         }
    }
}
