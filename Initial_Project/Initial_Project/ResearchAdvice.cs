using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Initial_Project
{
    class ResearchAdvice
    {
        public static void ResearchTest(IWebDriver driver)
        {
            var ProductUrl = "https://www.investsmart.com.au/shares";
            driver.Navigate().GoToUrl(ProductUrl);
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);

            //Actions act = new Actions(driver); 
            
           

            //    File scrFile = ((TakesScreenshot)driver).getScreenshotAs(OutputType.FILE);
            //FileUtils.copyFile(scrFile, new File("D:\\testScreenShot.jpg"));




        }
    }
}
