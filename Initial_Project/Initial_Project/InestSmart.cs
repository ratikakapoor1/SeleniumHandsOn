using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_Project
{
    class InestSmart
    {

        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("www.investsmart.com.au");

            int t= driver.FindElements(By.TagName("a")).Count;

            Console.WriteLine(t);

            driver.Close();
            driver.Quit();

        }
    }
}
