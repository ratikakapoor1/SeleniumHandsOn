using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace ISFramework.Driver
{
    public interface ITestDriver
    {
        string ID { get; }
        void OpenURL(string URL);
        string URL { get; }
        void Quit();
        ReadOnlyCollection<IWebElement> FindElements(string cssSelector);
        IWebElement FindElement(string cssSelector);
        bool Exists(string cssSelector);
        bool IsVisible(string cssSelector);
        void Click(string cssSelector);
        void Click(IWebElement webElement);
        void ClickViaJavascript(IWebElement webElement);
        string GetText(string cssSelector);
        void SendText(string cssSelector, string text);
        int Count(string cssSelector);

        // Applicable to select dropdown control
        void SelectItemByTextInDropdown(string cssSelector, string text);
        void SelectItemByValueInDropdown(string cssSelector, string value);

        // Applicable to radio and check boxes
        void CheckItemByValue(string cssSelector, string value);

        void ClickOkButtonOnConfirmDialog();

        string WindowTitle { get; }
        object ExecuteJavaScript(string script, params object[] args);

        bool WaitUntil(Func<bool> condition, int maxWaitTimeInMilliseconds = -1);
        void Implicitwait();
    }
}
