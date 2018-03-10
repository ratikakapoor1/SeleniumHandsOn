//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Initial_Project
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
    
//            IWebDriver driver = new ChromeDriver();

//            //2 methods to open website
//             driver.Navigate().GoToUrl("http://www.gmail.com");
//            //{
//            //    Url = ("http://www.google.com")
//            //};

//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);

//            driver.FindElement(By.Id("identifierId")).SendKeys("ratikakapoor1@gmail.com");
//            driver.FindElement(By.Id("identifierNext")).Click();
            
//            driver.FindElement(By.Id("password")).SendKeys("zaq1QAZ1");
//            driver.FindElement(By.Id("passwordNext")).Click();

//            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 20);
//            driver.FindElement(By.Id("idvPreregisteredPhoneNext")).Click();

//            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);

//            string pth = driver.FindElement(By.XPath("#y9 > div > div.aio.UKr6le > span > a")).Text;

//            Console.Write(pth);
//            Console.ReadKey();
//        }


//    }
//}
