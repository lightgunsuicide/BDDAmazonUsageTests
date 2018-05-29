using System;
using System.Threading;
using Dependencies.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Framework.PageClasses
{
    public class HomePage : IHomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void launchSite(string homepage)
        {
            driver.Navigate().GoToUrl(homepage);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='twotabsearchtextbox']")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='nav-search']/form/div[2]/div/input")]
        public IWebElement searchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchDropdownBox']")]
        public IWebElement categoryDropDown { get; set; }

        public void enterSearchTerm(string searchTerm)
        {
            SearchField.SendKeys(searchTerm);
        }

        public ISearchResults clickSearchButton()
        {
            searchButton.Click();
            return new SearchResults();
        }

        public ICategoryPage clickSearchForCategory()
        {
            searchButton.Click();
            Thread.Sleep(5000);
            return new CategoryPage(driver);
        }

        public void selectCategory(string categoryName)
        {
            new SelectElement(categoryDropDown).SelectByText(categoryName);
            
        }

    }
}
