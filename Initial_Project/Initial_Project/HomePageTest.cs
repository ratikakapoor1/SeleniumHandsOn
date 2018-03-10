using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_Project
{
    class HomePageTest

    {
        public static void HomePageTesting(IWebDriver driver)
        {            
            LoginFunc.LoginCorrectDeatils(driver);
                    
            //checking for 9 items at end          
            IList<IWebElement> listcount = driver.FindElements(By.CssSelector("div.tile.portfolio-tile"));

            if (listcount.Count == 9)
            {
                Console.WriteLine("list verified");
            }
            else
            {
                Console.WriteLine("elements:" + listcount.Count);
            }

            //checking for 8 images at center          
            IList<IWebElement> itemcount = driver.FindElements(By.CssSelector("div.card.card-news-insights article"));
            
            if (itemcount.Count == 8)
            {
                Console.WriteLine("images verified at center");
            }
            else
            {
                Console.WriteLine("images:" + itemcount.Count);
            }

           
        }

    }
}
