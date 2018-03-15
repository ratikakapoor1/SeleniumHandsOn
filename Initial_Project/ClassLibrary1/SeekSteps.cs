using System;
using TechTalk.SpecFlow;
using Implementation;
using NUnit.Framework;
using System.Threading;

namespace ClassLibrary1
{
    [Binding]
    public class SeekSteps
    {
        [Given(@"I open (.*)")]
        public void GivenIOpenWebsite(string url)
        {
            DriverInit.Initialize();
            Implement.OpenUrl(url);
            Implement.ImplicitWait();
        }
        
        [Given(@"click on Sign In")]
        public void GivenClickButton()
        {
            SeekMethod.Click(SearchSelectors.SignInLink);
        }
        
        [When(@"I enter email (.*) and password (.*) and click Sign in")]
        public void WhenILogin(string userName, string passWord)
        {
            SeekMethod.EnterInTextBox(SearchSelectors.UsernameCss, userName);
            SeekMethod.EnterInTextBox(SearchSelectors.PasswordCss, passWord);
            SeekMethod.Click(SearchSelectors.SignInButton);
            Implement.ImplicitWait();
            Thread.Sleep(10);
        }
        
        [Then(@"the home page is opened with name Ratika")]
        public void ThenTheHomePageIsDisplayed()
        {
            string ActPageTitle = SeekMethod.FindPageTitle();
            string ActElementTitle = SeekMethod.FindElementTitle(SearchSelectors.ElementCss);
            string ExpPageTitle = "SEEK - Australia's no. 1 jobs, employment, career and recruitment site";

            Assert.AreEqual(ExpPageTitle, ActPageTitle);
            Assert.AreEqual("Ratika", ActElementTitle);
            DriverInit.Cleanup();
        }
    }
}
