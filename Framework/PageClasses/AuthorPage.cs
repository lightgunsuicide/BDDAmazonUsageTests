using System;
using System.Collections.Generic;
using Dependencies.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.PageClasses
{
    public class AuthorPage : IAuthorPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='ap-bio']/div/div[1]/span/text()")]
        public IWebElement description { get; set; }

        public string authorDescription()
        {
            return description.Text;
        }
    }
}
