using System;
using System.Collections.Generic;
using Dependencies.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.PageClasses
{
    public class AuthorPage : IAuthorPage
    {
        IWebDriver driver;
      
        [FindsBy(How = How.XPath, Using = "//*[@id='ap-bio']/div/div[1]/span")]
        public IWebElement description { get; set; }

        public AuthorPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public string authorDescription()
        {
            return description.Text;
        }
    }
}
