using System;
using TechTalk.SpecFlow;
using Implementation;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;

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
            Implement.ExplicitWait(() => (DriverInit.driver.FindElement(By.CssSelector(SearchSelectors.ElementCss)).Text != null));
        }

        [Then(@"the home page is opened with name Ratika")]
        public void ThenTheHomePageIsDisplayed()
        {
            string ExpPageTitle = "SEEK - Australia's no. 1 jobs, employment, career and recruitment site";
            string ActElementTitle = SeekMethod.FindElementTitle(SearchSelectors.ElementCss);
            //string ActElementTitle1 = SeekMethod.FindElementTitle(SearchSelectors.ElementCss1);
            string ActPageTitle = SeekMethod.FindPageTitle();
            
            Assert.AreEqual(ExpPageTitle, ActPageTitle);
            //Assert.IsTrue("Ratika".Equals(ActElementTitle)  || "Ratika".Equals(ActElementTitle1));
            DriverInit.Cleanup();
        }
    }
}
