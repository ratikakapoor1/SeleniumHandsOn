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


namespace ClassLibrary1
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public static void TestMethod()
        {
            string url = "https://www.seek.com.au/";
            //string css = "#AvatarFavouriteSearchesLink";
            DriverInit.Initialize();
            Implement.OpenUrl(url);
            Implement.ImplicitWait();

            //DriverInit.driver.FindElement(By.CssSelector(searchCss)).SendKeys(rati);
            //DriverInit.driver.FindElement(By.CssSelector(searchCss)).SendKeys(val);




            DriverInit.Cleanup();
        }
    }
}
