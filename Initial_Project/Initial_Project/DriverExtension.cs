using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_Project
{
    public static class DriverExtension
    {

      
        public static bool WaitUnit(this IWebDriver driver, Func<bool> condition)
        {
            try
            {
                var abc = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                abc.PollingInterval = TimeSpan.FromSeconds(10);
                abc.Until(a => condition);
                
            }
            catch (Exception)
            {
            }
            return true;
        }
    }
}
