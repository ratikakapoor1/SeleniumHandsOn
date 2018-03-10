using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Initial_Project
{
    class ProductPageTest
    {
        public static void ProductTest(IWebDriver driver)
        {
            var ProductUrl = "https://www.investsmart.com.au/invest-with-us/investsmart-diversified-income-model/1";
            driver.Navigate().GoToUrl(ProductUrl);

            driver.FindElement(By.CssSelector("div.options a:nth-child(1)")).Click();
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);
            //chk submit button disabled if nothing eneterd
            var fn = driver.FindElement(By.CssSelector("#downloadPdsModal input[name='FirstName']")).Text;
            var ln = driver.FindElement(By.CssSelector("#downloadPdsModal input[name='LastName']")).Text;
            var email = driver.FindElement(By.CssSelector("#downloadPdsModal input[name='Email']")).Text;

            if (string.IsNullOrEmpty(fn) || string.IsNullOrEmpty(ln) || string.IsNullOrEmpty(email))
                {
                Console.WriteLine("inside loop");
                var cond = driver.FindElement(By.CssSelector("#downloadPdsModal button[class^=btn]")) .Enabled;
                Console.WriteLine("cond chk in loop:  cond =" + cond);
                if (!cond)
                {
                    Console.WriteLine("Enter mandatory details");
                    //Assert.IsTrue(cond.Equals("False"));

                    driver.FindElement(By.CssSelector("#downloadPdsModal input[name='FirstName']")).SendKeys("xyx");
                    driver.FindElement(By.CssSelector("#downloadPdsModal input[name='LastName']")).SendKeys("abc");
                    driver.FindElement(By.CssSelector("#downloadPdsModal input[name='Email']")).SendKeys("abc@gmail.com");
                    driver.FindElement(By.CssSelector("#downloadPdsModal button.btn.btn-primary")).Click();
                    //driver.Manage(). = new TimeSpan(0, 1, 0);
// calling WaitUntil func with condition.
                    driver.WaitUnit(()=>driver.Url.Contains(".pdf"));
                    Console.WriteLine("pdf generated");
                    Console.WriteLine("finish");
                }
            }
        }
       

        public static void ValueTest(IWebDriver driver)
        {
            var ProductUrl = "https://rs-www.investsmart.com.au/invest-with-us/investsmart-diversified-income-model/1";
            driver.Navigate().GoToUrl(ProductUrl);
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 15);

            IList<IWebElement> list = driver.FindElements(By.CssSelector("ul.parametrs-list.list-unstyled.details-section > li strong"));
            var cnt = list.Count;
            Console.WriteLine("count = " + cnt);

            for (int i=0;i<cnt;i++)
            {
                var num =list[i].Text.Replace("%","").Replace("+", "").Replace("years", "").Replace(" ", "");
                double.TryParse(num, out double num1);
                if (num1 > 0)
                {
                    Console.WriteLine("verified number is =" + num1);
                }
                else
                {
                    Console.WriteLine("number is ="+num1);
                }

            }
            //foreach (var item in list)
            //{
            //    Console.WriteLine("text at item = " + item.Text.Replace("%","").Replace("+","").Replace("years","").Replace(" ",""));

            //}


            IList<IWebElement> list1 = driver.FindElements(By.CssSelector("div.history-list dd"));
            Console.WriteLine("list item = " + list1.Count);
            var sum = 0.0;

            for (int i = 0; i < list1.Count; i++)
            {
                var nn = list1[i].Text.Replace("%", "");
                double.TryParse(nn, out double val);
                sum = sum + val;
                Console.WriteLine("sum = " + sum);
            }

            //foreach (var item in list1)
            //{
            //    Console.WriteLine("text at item = " + item.Text);

            //}
        }
    }
}
