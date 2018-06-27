using Implementation;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Firefox;


namespace ClassLibrary1
{
    [TestFixture]
    public class NUnitTestFile
    {
        [Test]
        public static void TestMethod()
        {
            //string url = "https://www.seek.com.au/";
            ////string css = "#AvatarFavouriteSearchesLink";
            //DriverInit.Initialize();
            //Implement.OpenUrl(url);
            //Implement.ImplicitWait();

            ////DriverInit.driver.FindElement(By.CssSelector(searchCss)).SendKeys(rati);
            ////DriverInit.driver.FindElement(By.CssSelector(searchCss)).SendKeys(val);

            //DriverInit.Cleanup();


         //*******path set for geckodriver in environment variables**************
            //System.setProperty("webdriver.gecko.driver", "C:\\\\Temp\\SeleniumHandsOn\\Initial_Project\\NUnitTesting\\bin\\Debug");
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.toolsqa.com");
            
            //Thread.Sleep(5000);
            driver.Close();
        }
	
    }
}
