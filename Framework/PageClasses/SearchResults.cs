using System;
using Dependencies.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.PageClasses
{
    public class SearchResults : ISearchResults
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='result_0']/div/div/div/div[2]/div[1]/div[2]/span[2]")]
        public IWebElement authorLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='result_0']/div/div/div/div[2]/div[1]/div[2]/span[2]")]
        public IWebElement firstResultAuthorText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='result_0']/div/div/div/div[2]/div[2]/div[1]/div[2]/a/span")]
        public IWebElement firstResultPriceText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='result_0']/div/div/div/div[2]/div[1]/div[1]/a/h2")]
        public IWebElement firstResultTitleText { get; set; }

        IWebDriver driver;
        public SearchResults(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IAuthorPage clickAuthorLink()
        {
            authorLink.Click();
            return new AuthorPage(driver);
        }

        public string firstResultAuthor()
        {
            return firstResultAuthorText.Text;
        }

        public string firstResultPrice()
        {
            return firstResultPriceText.Text;
        }

        public string firstResultTitle()
        {
            return firstResultTitleText.Text;
        }
    }
}
