using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using BDD.IoC.Interfaces;
using FluentAssertions;
using System.Collections.Generic;
using System.Configuration;

namespace BDD.Steps
{
    [Binding]
    public class BrowsingItemsSteps
    {
        IHomePage _homePage;
        ISearchResults _searchResults;
        ICategoryPage _categoryPage;
        IAuthorPage _authorPage;

        string _categoryName;

        [Given(@"I open amazon in a browser")]
        public void GivenIOpenAmazonInABrowser()

        {
            IWebDriver driver =  ScenarioContext.Current.Get<IWebDriver>("driver");
            _homePage.launchSite(ConfigurationManager.AppSettings["baseUrl"]);
        }
        
        [Given(@"I search for ""(.*)""")]
        public void GivenISearchFor(string searchTerm)
        {
            _homePage.enterSearchTerm(searchTerm);
            _searchResults = _homePage.clickSearchButton();
        }

        [Then(@"I should see results for ""(.*)"" including ""(.*)"" and ""(.*)""")]
        public void ThenIShouldSeeResultsForIncludingAnd(string title, string author, Decimal price)
        {
            _searchResults.firstResultTitle().Should().Be(title);
            _searchResults.firstResultAuthor().Should().Be(author);
            _searchResults.firstResultPrice().Should().Be(price);
        }

        [When(@"I select ""(.*)"" from the category drop down")]
        public void WhenISelectFromTheCategoryDropDown(string categoryName)
        {
            _homePage.selectCategory(categoryName);
            _categoryPage = _homePage.clickSearchForCategory();
        }


        [Then(@"I should see the landing page for this category")]
        public void ThenIShouldSeeTheLandingPageForThisCategory()
        {
            _categoryPage.categoryPageHeader().Should().Be(_categoryName);
        }

        [When(@"I open the link to his page")]
        public void WhenIOpenTheLinkToHisPage()
        {
           _authorPage = _searchResults.clickAuthorLink();
        }


        [Then(@"I see only books by ""(.*)""")]
        public void ThenISeeOnlyBooksBy(string authorName)
        {
           List<string> authorNamesListed = _authorPage.getListOfAuthorsOnPage();
            foreach (string author in authorNamesListed) {
                author.Should().Be(authorName);
            }
        }
        
        [Then(@"some information about ""(.*)""")]
        public void ThenSomeInformationAbout(string authorName)
        {
            _authorPage.authorDescription().Should().Contain(authorName);
        }
    }
}
