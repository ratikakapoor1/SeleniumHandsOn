using ISFramework.Driver;
using ISFramework.PageObjectModel.Pages;

namespace ISFramework.Pages
{
    public class PageHomeFactory
    {
        public static IPageHome GetPageHome(ITestDriver driver) { return new PageHome(driver); }
    }
}
