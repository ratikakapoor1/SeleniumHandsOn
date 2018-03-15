using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Implementation
{
    public class Implement
    {
        public static void OpenUrl(string url)
        {
                      if (!url.Contains("http://") && !url.Contains("https://"))
            {

                url = "http://" + url;
            }
           
            DriverInit.driver.Navigate().GoToUrl(url);
        }

        public static void ImplicitWait()
        {
            DriverInit.driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 20);
        }

        public static void ExplicitWait()
        {
            IWait<IWebDriver> wait = new WebDriverWait(DriverInit.driver, TimeSpan.FromSeconds(20))

            { PollingInterval = TimeSpan.FromMilliseconds(100)
                        };
        }

        public static void SearchItem(string val)
        {
            DriverInit.driver.FindElement(By.CssSelector(SearchSelectors.InputSearchBox)).SendKeys(val);
            DriverInit.driver.FindElement(By.CssSelector(SearchSelectors.SearchButton)).Click();
        }

        public static void DismissAlert()
        {
            IAlert alert = DriverInit.driver.SwitchTo().Alert();
            alert.Dismiss();
                       
        }

    }
}
 