using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implementation;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Implementation
{
    public static class SeekMethod
    {
        public static void Click(string searchCss)
        {
            DriverInit.driver.FindElement(By.CssSelector(searchCss)).Click();
        }

        public static void EnterInTextBox(string searchCss, string val)
        {
            DriverInit.driver.FindElement(By.CssSelector(searchCss)).SendKeys(val);
        }

        public static string FindElementTitle(string searchCss)
        {
            string title = DriverInit.driver.FindElement(By.CssSelector(searchCss)).Text;
            return title.Trim();
        }

        public static string FindPageTitle()
        {
            return DriverInit.driver.Title;
        }
    }

}
