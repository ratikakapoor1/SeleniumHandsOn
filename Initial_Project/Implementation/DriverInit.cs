using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public static class DriverInit
    {
        public static IWebDriver driver;

        public  static void Initialize()
        {
            driver = new ChromeDriver();
        }
        

        public static void Cleanup()
        {
            driver.Quit();
        }
    }
}
