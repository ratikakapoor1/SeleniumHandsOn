using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting.LoginTestCases
{
    [TestFixture]
    class LoginFunc
    {
        IWebDriver driver = null;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }

        [TestCase("asa", "sa")]
        [TestCase("asaa", "sa")]
        [TestCase("asads", "sa")]
        public void LoginCorrectDeatils(string userName, string pwd)
        {
            //var loginId = ConfigurationManager.AppSettings["loginid"];
            //var abc = File.ReadLines("");
           
            driver.Navigate().GoToUrl("http://www.investsmart.com.au");
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);
            driver.FindElement(By.CssSelector("div.tool-hold a")).Click();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(120));
           //     .ImplicitWait = new TimeSpan(0, 0, 10);
           

            driver.FindElement(By.CssSelector("#Email")).Clear();
            driver.FindElement(By.CssSelector("#Email")).SendKeys("cton0385@gmail.com");
            driver.FindElement(By.CssSelector("#Password")).Clear();
            driver.FindElement(By.CssSelector("#Password")).SendKeys("password");
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 5);
            driver.FindElement(By.CssSelector("input[value*='og i']")).Click();
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 15);
        }


        public static void Login(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.investsmart.com.au");
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);
            var str = driver.FindElement(By.CssSelector("div.tool-hold a")).GetAttribute("href");
            driver.FindElement(By.CssSelector("div.tool-hold a")).Click();
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);

            var str1 = driver.FindElement(By.CssSelector("div.main-content h3")).Text;
            var str2 = driver.Url;

            if (str1 == "Log in" && str != str2)
            { Console.WriteLine("Login page reached"); }
            else
            {
                Console.WriteLine("Login page not reached");
            }

            //chk with no credentials
            driver.FindElement(By.CssSelector("#Email")).Clear();
            driver.FindElement(By.CssSelector("#Password")).Clear();
            driver.FindElement(By.CssSelector("input[value*='og i']")).Click();

            //check error msg for empy fields
            var msg1 = driver.FindElement(By.CssSelector("div.alert.alert-danger")).Displayed;

            if (msg1.Equals(true))
            {
                Console.WriteLine("empty credentials");
            }
            else
            {
                Console.WriteLine("with empty credentials msg1=  " + msg1);
            }
            //chk with incorrect details
            driver.FindElement(By.CssSelector("#Email")).SendKeys("cton03@gmail.com");
            driver.FindElement(By.CssSelector("#Password")).SendKeys("password");
            driver.FindElement(By.CssSelector("input[value*='og i']")).Click();

            //check error msg with incorrect details
            var msg = driver.FindElement(By.CssSelector("span.field-validation-error")).Text;

            if (msg == "Incorrect email address/password.")
            {
                Console.WriteLine("incorrect mail id");
            }
            else
            {
                Console.WriteLine("did not chk incorrect mail id and msg= " + msg);
            }

            //chk with correct credentials

            driver.FindElement(By.CssSelector("#Email")).Clear();
            driver.FindElement(By.CssSelector("#Email")).SendKeys("cton0385@gmail.com");
            driver.FindElement(By.CssSelector("#Password")).Clear();
            driver.FindElement(By.CssSelector("#Password")).SendKeys("password");
            driver.FindElement(By.CssSelector("input[value*='og i']")).Click();

            var msg2 = driver.FindElement(By.CssSelector("div.text a[title='Log Off']")).Displayed;

            if (msg2.Equals(true))
            {
                Console.WriteLine("login successful:  ");
            }
            else
            {
                Console.WriteLine("login unsuccessful");
            }

            Console.WriteLine("finish");


        }
    }
}
