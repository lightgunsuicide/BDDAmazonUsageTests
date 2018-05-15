using System;
using Dependencies.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

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
        public ISearchResults clickSearchButton()
        {
            throw new System.NotImplementedException();
        }

        public ICategoryPage clickSearchForCategory()
        {
            throw new System.NotImplementedException();
        }

        public void enterSearchTerm(string searchTerm)
        {
            throw new System.NotImplementedException();
        }

        public void launchSite(string url)
        {
            throw new System.NotImplementedException();
        }

        public void selectCategory(string categoryName)
        {
            throw new System.NotImplementedException();
        }
        //public void launchSite(string homepage)
        //{
        //    driver.Navigate().GoToUrl(homepage);
        //}

        //[FindsBy(How = How.XPath, Using = "//*[@id='twotabsearchtextbox']")]
        //public IWebElement SearchField { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='nav-search']/form/div[2]/div/input")]
        //public IWebElement searchButton { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='searchDropdownBox']")]
        //public IWebElement categoryDropDown { get; set; }

        //public void enterSearchTerm(string searchTerm)
        //{
        //    SearchField.SendKeys(searchTerm);
        //}

        //public ISearchResults clickSearchButton()
        //{
        //    //searchButton.Click();
        //    //return new SearchResults();
        //    throw new NotImplementedException();
        //}

        //public ICategoryPage clickSearchForCategory()
        //{
        //    // searchButton.Click();
        //    // return new CategoryPage();
        //    throw new NotImplementedException();
        //}

        //public void selectCategory(string categoryName)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
