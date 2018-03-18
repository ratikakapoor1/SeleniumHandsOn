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


    }
}
