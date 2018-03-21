using System;
using TechTalk.SpecFlow;
using Implementation;
using OpenQA.Selenium;
using NUnit.Framework;

namespace ClassLibrary1
{
    [Binding]
       public class InvestSmartSteps
    {
        [Given(@"I invoke (.*)")]

        public void ISGivenIOpenWebsite(string url)
        {
            DriverInit.Initialize();
            Implement.OpenUrl(url);
            Implement.ImplicitWait();
        }

        [Given(@"then click on Log In")]
        public void ISGivenClickButton()
        {
            SeekMethod.Click(SearchSelectors.ISLogInLink);
        }

        [When(@"I put username (.*) and password (.*) and click Log in")]
        public void ISWhenILogin(string userName, string passWord)
        {
            SeekMethod.EnterInTextBox(SearchSelectors.ISUsernameCss, userName);
            SeekMethod.EnterInTextBox(SearchSelectors.ISPasswordCss, passWord);
            SeekMethod.Click(SearchSelectors.ISLogInButton);
            //  Implement.ExplicitWait(() => (DriverInit.driver.FindElement(By.CssSelector(SearchSelectors.ISElementCss)).Text != null));
           // Implement.ExplicitWait(() => (!(DriverInit.driver.Url.Contains("log -in"))));
        }

        [Then(@"the landing page is opened with Log off text")]

        public void ISThenTheHomePageIsDisplayed()
        {
            Implement.ExplicitWait(() => (!(DriverInit.driver.Url.Contains("log -in"))));
            string ExpUrl = "https://www.investsmart.com.au/";
            string ActUrl= DriverInit.driver.Url;
            string ActElementTitle = SeekMethod.FindElementTitle(SearchSelectors.ISElementCss);
            
            Assert.AreEqual(ExpUrl, ActUrl);
            Assert.AreEqual("Log out", ActElementTitle);
            DriverInit.Cleanup();
        }

        [Then(@"the page is displayed with error message")]
        public void ISErrorMessagePageForIncorrectLoginDetails()
        {
            string ExpError = "Incorrect email address/password.";
            string ActualError = SeekMethod.FindElementTitle(SearchSelectors.ISLoginError);
            Assert.AreEqual(ExpError, ActualError);
            DriverInit.Cleanup();
        }


        [When(@"I put username (.*) and blank password and click Log in")]
        public void ISWhenIPutBlankPassword(string userName)
        {
            SeekMethod.EnterInTextBox(SearchSelectors.ISUsernameCss, userName);
            SeekMethod.Click(SearchSelectors.ISLogInButton);
        }
      
        [Then(@"the page is displayed with error message that password is mandatory")]
        public void ThenThePageIsDisplayedWithErrorMessageThatPasswordisMandatory()
        {
            string ExpError = "The Password field is required.";
            string ActualError = SeekMethod.FindElementTitle(SearchSelectors.ISLoginError);
            Assert.AreEqual(ExpError, ActualError);
            DriverInit.Cleanup();
        }

        // Invest Wth US page
      
        [Given(@"I click Invest With Us link")]
        public void GivenIClickInvestWithUsLink()
        {
            SeekMethod.Click(SearchSelectors.IWSInvestWithUsLink);
        }


        [When(@"I select Strategy as (.*) , Type as (.*) , Management Style as (.*)")]
        public void WhenISelectFilters(string strategy, string type, string style)
        {
            //DriverInit.driver.FindElement(By.CssSelector(SearchSelectors.IWSStrategyDropDown)).Click();

            InvestSmart.SelectItemByValueInDropdown(SearchSelectors.IWSStrategyDropDown, strategy);
            InvestSmart.SelectItemByValueInDropdown(SearchSelectors.IWSTypeDropDown, type);
            InvestSmart.SelectItemByValueInDropdown(SearchSelectors.IWSStyleDropDown, style);
            Implement.ImplicitWait();

        }

        
        [Then(@"No products found should be displayed")]
        public void ThenNoProductsFoundShouldBeDisplayed()
        {
            string ActualErrDesc = SeekMethod.FindElementTitle(SearchSelectors.IWSErrorDesc);
            string ExpErrorDesc = "No products found";
            Assert.AreEqual(ExpErrorDesc, ActualErrDesc);
            DriverInit.Cleanup();
        }

        // Shares page
        [Given(@"click on Shares link")]
        public void GivenClickOnSharesLink()
        {
            // SeekMethod.Click(SearchSelectors.SPSharesLink);
            var WebElement = DriverInit.driver.FindElement(By.CssSelector(SearchSelectors.SPSharesLink));
            InvestSmart.ClickViaJavascript(WebElement);
            Implement.ExplicitWait(() => (DriverInit.driver.Url.Contains("shares")));
              
        }

        [When(@"I enter sector as (.*) and click Find Shares")]
        public void WhenIEnterSectorAsEnergyAndClickFindShares(string sector )
        {
            InvestSmart.SelectItemByValueInDropdown(SearchSelectors.SPDropdownCss, sector);
            SeekMethod.Click(SearchSelectors.SPFindSharesButton);
            Implement.ImplicitWait();
        }

        [Then(@"search results should have Sector as energy")]
        public void ThenSearchResultsShouldHaveSectorAsEnergy()
        {
           var els = DriverInit.driver.FindElements(By.CssSelector("div.table-responsive > table > tbody > tr"));
            int count = els.Count;
            for (int i =1; i<=count; i++)
            {
                string val = DriverInit.driver.FindElement(By.CssSelector($"div.table-responsive > table > tbody > tr:nth-child({i}) > td:nth-child(3)")).Text;
                Assert.AreEqual("Energy", val);
            }
            DriverInit.Cleanup();
        }


    }
}
