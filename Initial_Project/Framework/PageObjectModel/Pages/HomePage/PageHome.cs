using ISFramework.Driver;
using ISFramework.Pages;

namespace ISFramework.PageObjectModel.Pages
{
    public class PageHome : PageBase, IPageHome
    {
        public PageHome(ITestDriver driver) : base(driver, new PageHomeUIMap())
        {
        }
        public void ClickHeaderNavItems()
        {
            ClickElements(UIMap.NavItemsCss);
        }
        public override void ClickPrimaryButtons()
        {
            ClickElements(UIMap.PrimaryButtonsCss);
        }

        public override void ClickSecondaryButtons()
        {
            ClickElements(UIMap.SecondaryButtonsCss);
        }

        private PageHomeUIMap UIMap { get { return (PageHomeUIMap)uiMap; } }
        public bool IsVisible { get { return Driver.IsVisible(""); } }
    }
}
