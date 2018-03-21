using ISFramework.Driver;
using ISFramework;
using ISFramework.Pages;

namespace ISFramework
{
    public class WebManager
    {
        internal static ITestDriver Driver { get; private set; }

        public static void Initialize()
        {
            if (Driver == null)
            {
                Driver = DriverFactory.GetTestDriver(Config.BrowserType,
                                                        Config.ImplicitWaitTimeOutInMilliseconds,
                                                        Config.DefaultExplilicitWaitTimeOutInMilliseconds,
                                                        false,
                                                        Config.DriverLocation, Config.RemoteDriverUrl);
                CreatePages();
            }
        }

        public static void Cleanup()
        {
            Driver.Quit();
            Driver = null;
        }

        public static void OpenWebpage(string strURL)
        {
            Driver.OpenURL(strURL);
        }

        public static string URL { get { return Driver.URL; } }

        private static void CreatePages()
        {
            PageHome = PageHomeFactory.GetPageHome(Driver);
            //PageInvestWithUs = PageInvestWithUsFactory.GetPageInvestWithUs(Driver);
            //PageInvestWithUsDetails = PageInvestWithUsDetailsFactory.GetPageInvestWithUsDetails(Driver);
            //PageShares = PageSharesFactory.GetPageShares(Driver);
            //PageCompanyProfile = PageCompanyProfileFactory.GetPageCompanyProfileDetails(Driver);
        }
        public static IPageHome PageHome { get; private set; }
        //public static IPageInvestWithUs PageInvestWithUs { get; private set; }
        //public static IPageInvestWithUsDetails PageInvestWithUsDetails { get; private set; }
        //public static IPageShares PageShares { get; private set; }
        //public static IPageCompanyProfile PageCompanyProfile { get; private set; }
    }
}
