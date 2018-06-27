using ISFramework.Driver;
using ISFramework.PageObjectModel.Pages;

namespace ISFramework.Pages
{
    public class SharesPageFactory
    {
        public static ISharesPage GetSharesPagee(ITestDriver driver) { return new SharesPage(driver); }
    }
}
