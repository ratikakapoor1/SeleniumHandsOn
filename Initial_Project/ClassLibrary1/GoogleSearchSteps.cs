using Implementation;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace ClassLibrary1
{
    [Binding]
    public class GoogleSearchSteps
    {
        [Given(@"I navigate to (.*)")]
        public void GivenINavigateToUrl(string url)
        {
            DriverInit.Initialize();
            Implement.OpenUrl(url);
            Implement.ImplicitWait();
        }

        [When(@"I search for (.*)")]
        public void WhenISearchForItem(String val)
        {
            Implement.SearchItem(val);
        }

        [Then(@"Google should return valid search results")]
        public void ThenGoogleShouldReturnValidSearchResults()
        {
            Assert.AreEqual("kitten - Google Search", DriverInit.driver.Title);
            DriverInit.Cleanup();
        }

        

    }
}
