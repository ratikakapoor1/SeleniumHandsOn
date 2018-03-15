using System;
using TechTalk.SpecFlow;
using Implementation;

namespace ClassLibrary1
{
    [Binding]
    public class JabongSteps
    {
        [Given(@"I have opened (.*) home page")]
        public void GivenIHaveOpenedHomePage(string url)
        {
            DriverInit.Initialize();
            Implement.OpenUrl(url);
            Implement.ImplicitWait();
        }
        
        [When(@"I click on link (.*) under Women")]
        public void WhenIClickOnLinkUnderCategory(string link)
        {
           Implement.SearchItem(link);
        }

        [Then(@"a new page should be opened with title (.*) and have images")]
        public void ThenANewPageShouldBeOpenedWithTitleandImages(string title)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
