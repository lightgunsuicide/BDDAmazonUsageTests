using Dependencies.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.PageClasses
{
    public class CategoryPage : ICategoryPage
    {
        IWebDriver driver;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='fst-hybrid-dynamic-h1']/div/h1/b")]
        public IWebElement headerText { get; set; }

        public CategoryPage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string categoryPageHeader()
        {
            return headerText.Text;
        }
    }
}