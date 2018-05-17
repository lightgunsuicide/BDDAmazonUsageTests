using Dependencies.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.PageClasses
{
    public class CategoryPage : ICategoryPage
    {
        [FindsBy(How = How.XPath, Using ="//*[@id='merchandised-content']/div[1]/h1/b")]
        public IWebElement headerText { get; set; }

        public string categoryPageHeader()
        {
            return headerText.Text;
        }
    }
}
