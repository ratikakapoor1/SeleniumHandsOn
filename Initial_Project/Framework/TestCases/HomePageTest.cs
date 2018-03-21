using ISFramework;
using NUnit.Framework;

namespace InvestSMART.Test.Automation.TestCases
{
    public class HomePageTest : TestBase
    {
        private static void NavigateToCurrentPage()
        {
            WebManager.OpenWebpage(WebManager.PageHome.PageUrl);
            WebManager.PageHome.WaitUntil(() => WebManager.PageHome.IsVisible);
        }
        [Test]
        public void Test_Home_Page_Click_HeaderNavItems()
        {
            NavigateToCurrentPage();
            WebManager.PageHome.ClickHeaderNavItems();
        }
        [Test]
        public void Test_Home_Page_Click_PrimaryButtons()
        {
            NavigateToCurrentPage();
            WebManager.PageHome.ClickPrimaryButtons();
        }
        [Test]
        public void Test_Home_Page_Click_SecondaryButtons()
        {
            NavigateToCurrentPage();
            WebManager.PageHome.ClickSecondaryButtons();
        }
    }
}
