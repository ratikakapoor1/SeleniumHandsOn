using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

namespace ISFramework.Driver
{
    class TestDriver : ITestDriver
    {
        private string _id = Guid.NewGuid().ToString();
        public string ID { get { return _id; } }

        private IWebDriver _iWebdriver;
        private int _defaultExplilicitWaitTimeOutInMilliseconds;

        public TestDriver(IWebDriver iWebdriver,
                            int defaultExplilicitWaitTimeOutInMilliseconds)
        {
            _iWebdriver = iWebdriver;
            _defaultExplilicitWaitTimeOutInMilliseconds = defaultExplilicitWaitTimeOutInMilliseconds;
        }

        public string URL { get { return _iWebdriver.Url; } }

        public string WindowTitle { get { return _iWebdriver.Title; } }

        public void Click(string cssSelector)
        {
            var webElement = _iWebdriver.FindElement(By.CssSelector(cssSelector));
            Click(webElement);
        }

        public void Click(IWebElement webElement)
        {
            var webDriverWait = new WebDriverWait(_iWebdriver, TimeSpan.FromSeconds(10));
            ExecuteJavaScript("window.scrollTo(0," + (webElement.Location.Y - 50) + ")");
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(webElement));
            webElement.Click();
        }
        public void ClickViaJavascript(IWebElement webElement)
        {
            ExecuteJavaScript("arguments[0].click()", webElement);
        }

        public ReadOnlyCollection<IWebElement> FindElements(string cssSelector)
        {
            return _iWebdriver.FindElements(By.CssSelector(cssSelector));

        }
        public IWebElement FindElement(string cssSelector)
        {
            return _iWebdriver.FindElement(By.CssSelector(cssSelector));
        }

        public object ExecuteJavaScript(string script, params object[] args)
        {
            return ((IJavaScriptExecutor)_iWebdriver).ExecuteScript(script, args);
        }

        public bool Exists(string cssSelector)
        {
            try
            {
                _iWebdriver.FindElement(By.CssSelector(cssSelector));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string GetText(string cssSelector)
        {
            return _iWebdriver.FindElement(By.CssSelector(cssSelector)).Text;
        }

        public bool IsVisible(string cssSelector)
        {
            return Exists(cssSelector) && _iWebdriver.FindElement(By.CssSelector(cssSelector)).Displayed;
        }

        public void OpenURL(string URL)
        {
            _iWebdriver.Navigate().GoToUrl(URL);
                       
        }

        public void Quit()
        {
            _iWebdriver.Quit();
        }

        public void SendText(string cssSelector, string text)
        {
            _iWebdriver.FindElement(By.CssSelector(cssSelector)).SendKeys(text);
        }

        private int _pollingInterval = 100;
        public bool WaitUntil(Func<bool> condition, int maxWaitTimeInMilliseconds = -1)
        {
            if (maxWaitTimeInMilliseconds == -1)
            {
                maxWaitTimeInMilliseconds = _defaultExplilicitWaitTimeOutInMilliseconds;
            }

            var webDriverWait = new WebDriverWait(_iWebdriver, TimeSpan.FromMilliseconds(maxWaitTimeInMilliseconds));
            webDriverWait.PollingInterval = TimeSpan.FromMilliseconds(_pollingInterval);
            Func<IWebDriver, bool> formattedCondition = (_iWebdriver => condition());
            bool result = false;
            try
            {
                result = webDriverWait.Until(formattedCondition);

            }
            catch
            { }
            return result;
        }

        public void Implicitwait()
        {
            _iWebdriver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 20);
        }

        public void ClickOkButtonOnConfirmDialog()
        {
            _iWebdriver.SwitchTo().Alert().Accept();
        }

        public int Count(string cssSelector)
        {
            return _iWebdriver.FindElements(By.CssSelector(cssSelector)).Count;
        }

        public void SelectItemByTextInDropdown(string cssSelector, string text)
        {
            var selectElement = new SelectElement(_iWebdriver.FindElement(By.CssSelector(cssSelector)));
            selectElement.SelectByText(text);
        }

        public void SelectItemByValueInDropdown(string cssSelector, string value)
        {
            var selectElement = new SelectElement(_iWebdriver.FindElement(By.CssSelector(cssSelector)));
            selectElement.SelectByValue(value);
        }

        public void CheckItemByValue(string cssSelector, string value)
        {
            var checkOrRadioControls = _iWebdriver.FindElements(By.CssSelector(cssSelector));
            foreach (var control in checkOrRadioControls)
            {
                if (control.GetAttribute("value") == value)
                {
                    ((IJavaScriptExecutor)_iWebdriver).ExecuteScript($"arguments[0].checked=true", control);
                    break;
                }
            }
        }
    }
}
