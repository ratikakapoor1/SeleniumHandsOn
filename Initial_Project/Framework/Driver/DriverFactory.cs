using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using System.IO;
using OpenQA.Selenium.Remote;

namespace ISFramework.Driver
{
    public class DriverFactory
    {
        public static ITestDriver GetTestDriver(string browserType,
                                                int implicitWaitTimeOutInMilliseconds,
                                                int defaultExplilicitWaitTimeOutInMilliseconds,
                                                bool openInPrivateMode,
                                                string driverLocation, string remoteDriverUrl = "")
        {
            return new TestDriver(GetWebdriver(browserType, implicitWaitTimeOutInMilliseconds, openInPrivateMode, remoteDriverUrl, driverLocation),
                                    defaultExplilicitWaitTimeOutInMilliseconds);
        }

        private static IWebDriver GetWebdriver(string browserType,
                                                int implicitWaitTimeOutInMilliseconds,
                                                bool openInPrivateMode, string remoteDriverUrl,
                                                string driverLocation = "")
        {
            string driverDirectoryPath = driverLocation;
            if (string.IsNullOrEmpty(driverDirectoryPath))
            {
                driverDirectoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            }

            int timeoutInMinutes = 30;
            var timeSpan = TimeSpan.FromMinutes(timeoutInMinutes);
            IWebDriver iWebdriver = null;
            switch (browserType)
            {
                case "chrome":
                    {
                        ChromeOptions chromeOptions = new ChromeOptions();
                        chromeOptions.AddArgument("no-sandbox");
                        chromeOptions.AddArguments("disable-infobars");
                        if (openInPrivateMode)
                        {
                            chromeOptions.AddArguments("incognito");
                        }
#if DEBUG
                        iWebdriver = new ChromeDriver(driverDirectoryPath, chromeOptions, timeSpan);

#else
                        var capability = chromeOptions.ToCapabilities();
                        iWebdriver = new RemoteWebDriver(new Uri(remoteDriverUrl), capability, timeSpan);
#endif
                        iWebdriver.Manage().Window.Maximize();
                    }
                    break;
                case "firefox":
                    {
                        iWebdriver = new FirefoxDriver();

                        iWebdriver.Manage().Window.Maximize();
                    }
                    break;
                case "IE":
                    {
                        EdgeOptions edgeOptions = new EdgeOptions();
                        iWebdriver = new EdgeDriver(driverDirectoryPath, edgeOptions, TimeSpan.FromMinutes(timeoutInMinutes));

                        iWebdriver.Manage().Window.Maximize();
                    }
                    break;

                default:
                    throw new Exception($"Testing on \"{browserType}\" browser is not yet supported.");
            }

            iWebdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(implicitWaitTimeOutInMilliseconds);
            return iWebdriver;
        }
    }
}
