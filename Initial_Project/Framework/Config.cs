using System.Configuration;

namespace ISFramework
{
    public class Config
    {
        //public static string WebsiteURL { get { return ConfigurationManager.AppSettings["WebsiteURL"]; } }
        public static string WebsiteURL { get { return "https://www.investsmart.com.au/"; } }
        public static string RemoteDriverUrl { get { return ConfigurationManager.AppSettings["RemoteDriverUrl"]; } }        
        public static string TestUserName { get { return ConfigurationManager.AppSettings["TestUserName"]; } }
        public static string TestUserPassword { get { return ConfigurationManager.AppSettings["TestUserPassword"]; } }
        public static int ImplicitWaitTimeOutInMilliseconds { get { return 10000; } }
        public static string BrowserType { get { return "chrome"; } }
        public static int DefaultExplilicitWaitTimeOutInMilliseconds { get { return 10000; } }
        public static string DriverLocation { get { return ""; } }
    }
}
