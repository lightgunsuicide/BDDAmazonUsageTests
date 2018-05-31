using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AmazonUsage
{
    [Binding]
    public sealed class Hooks {

        [BeforeScenario]
        public void BeforeScenario()
        {
            //ChromeDriver driver = new ChromeDriver();
            //ScenarioContext.Current.Add("driver", driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //ScenarioContext.Current.Get<IWebDriver>("driver").Dispose();
        }
    }
}
