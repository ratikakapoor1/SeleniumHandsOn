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
    public static class InvestSmart
    {
        public static void SelectItemByValueInDropdown(string cssSelector, string value)
        {
            var selectElement = new SelectElement(DriverInit.driver.FindElement(By.CssSelector(cssSelector)));
           // selectElement.SelectByValue(value);
            selectElement.SelectByText(value);

         }

        public static void ClickViaJavascript(IWebElement webElement)
        {
            ExecuteJavaScript("arguments[0].click()", webElement);
        }

        public static object ExecuteJavaScript(string script, params object[] args)
        {
            return ((IJavaScriptExecutor)DriverInit.driver).ExecuteScript(script, args);
        }
    }
}
