using ISFramework.Driver;
using ISFramework.PageObjectModel;
using ISFramework.PageObjectModel.Pages;
using ISFramework.Pages;

namespace ISFramework.PageObjectModel.Pages
{
    public class SharesPage : PageBase, ISharesPage
    {
        public SharesPage(ITestDriver driver) : base(driver, new SharesPageUIMap())
        {
        }
        public void FindAndClickLink()
        {
            var element = Driver.FindElement(UIMap.SPSharesLink);
            Driver.ClickViaJavascript(element);                     
        }

        public void EnterVal(string sector)
        {
            Driver.SelectItemByTextInDropdown(UIMap.SPDropdownCss, sector);
            Driver.Implicitwait();
        }
        public bool VerifyResult()
        {
            var els = Driver.FindElements(UIMap.SPTableCss);
            var count = els.Count;
            bool result = false;
            for (int i=1; i<count; i++)
            {
                string val = Driver.GetText(string.Format(UIMap.SPTableColumnCss, i));
                val.Equals("Energy");
            }
            return result;
       
         }
        
        
    private SharesPageUIMap UIMap { get { return (SharesPageUIMap)uiMap; } }
    public bool IsVisible { get { return Driver.IsVisible(""); } }
}
}
