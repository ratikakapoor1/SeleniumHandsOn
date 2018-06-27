using ISFramework;
using System;
using TechTalk.SpecFlow;


namespace ISFeatureFile
{
    [Binding]
    public class SharesPage
    {
        // Shares page
        [Given(@"I invoke Invest Smart application")]

        public void ISGivenIOpenWebsite()
        {
            WebManager.OpenWebpage(WebManager.SharesPage.PageUrl);
            WebManager.SharesPage.WaitUntil(() => WebManager.SharesPage.IsVisible);
        }

        [Given(@"click on (.*) link")]
        public void GivenClickOnSharesLink(string Link)
        {
            WebManager.SharesPage.FindAndClickLink();
            WebManager.SharesPage.WaitUntil(() => WebManager.SharesPage.IsVisible);
            //*****from where is visible getting css
            //Implement.ExplicitWait(() => (DriverInit.driver.Url.Contains("shares")));
        }

        [When(@"I enter sector as (.*) and click Find Shares")]
        public void WhenIEnterSectorAsEnergyAndClickFindShares(string sector)
        {
            WebManager.SharesPage.EnterVal(sector);
        }

        [Then(@"search results should have Sector as energy")]
        public void ThenSearchResultsShouldHaveSectorAsEnergy()
        {
            WebManager.SharesPage.VerifyResult();
        }
    }
}
