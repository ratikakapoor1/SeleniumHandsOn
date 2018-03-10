using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

//using OpenQA.Selenium.Safari;
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
            
            try
            {
                // direct calling of static functions
                //OpenApp(driver);
                //VerifyLink(driver);
                //LoginFunc.Login(driver);
                //calling by object method....for non static functions
                //LoginFunc newfun = new LoginFunc();
                //newfun.Login(driver);
                //  HomePageTest.HomePageTesting(driver);
               // ProductPageTest.ProductTest(driver);
                //ProductPageTest.ValueTest(driver);
                ResearchAdvice.ResearchTest(driver);
                Console.ReadKey();
            }
            finally
            {
                driver.Quit();
            }
        }

        public static void VerifyLink(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.investsmart.com.au");

            var name=driver.FindElement(By.CssSelector("div.intro-section.intro-home.large-mod h1"));
            string expected = "Welcome to InvestSMART";
            Console.WriteLine("Actual Value : "+name.Text.Trim()+"--------len:"+name.Text.Trim().Length);
            Console.WriteLine("Expected Value : " + expected+ "--------len:" + expected.Trim().Length);


            //var strng = "# main > div.intro-section.intro-home.large-mod > div.container > div.intro-info-container > div > div.col-12 col-md-4 text-center> div > div.col-3.col-md-12";
            //driver.FindElement(By.CssSelector("div.intro-info-container img"));
            
            if (name.Text.Trim() == expected.Trim())
            {
                Console.WriteLine("test pass");
             }
            else
            {
                Console.WriteLine("test fail");
            }
            Console.ReadKey();
            // Assert.IsTrue(name.Equals(expected));

            Actions actions = new Actions(driver);





        }

        public static void OpenApp(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.investsmart.com.au");

            //get link count
            //int t = driver.FindElements(By.TagName("a")).Count;
            //Console.WriteLine("total links= " +t);
            //Console.Read();

            //get link count by list
            IList<IWebElement> list = driver.FindElements(By.TagName("a"));
            int linkCount = list.Count;

            List<string> str = new List<string>();
            //var str = new List<string>();
            foreach (var item in list)
            {
                str.Add(item.GetAttribute("href"));
               
            }

            Console.WriteLine("links count = " + linkCount);
            for (int i = 0; i < linkCount; i++)
            {
                IList<IWebElement> list1 = driver.FindElements(By.TagName("a"));
                //string atr = list1[i].GetAttribute("href");
                //string atr = str[i];
                var element = list1[i];
                if ( element.Displayed)
                {
                    try
                    {
                        element.Click();
                    }
                    catch (Exception)
                    {

                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", element);    
                    }
                    finally
                    {
                        // list1[i].Click();
                        driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);
                        string newURL = driver.Url;

                        //Assert.IsTrue(newURL.Equals(str[i]));

                        if (newURL.Contains(str[i]))
                        { Console.WriteLine("link working" + list1[i]); }
                        else
                        { Console.WriteLine("new URL="+newURL+"------href"+str[i]); }

                        //Console.WriteLine("links name " +i+"="+ atr);
                        //driver.Navigate().GoToUrl(atr);

                        driver.Navigate().GoToUrl("http://www.investsmart.com.au");
                        driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);

                    }
                }
               

            }

           // driver.Navigate().GoToUrl("http://www.investsmart.com.au");

            //foreach (IWebElement result in list)
            //{

            //    string val = result.GetAttribute("href");
            //    Console.WriteLine("links name= " + val);

            //    result.Click();
            //    
            //}
            Console.Read();
            
        }
        }
    }


