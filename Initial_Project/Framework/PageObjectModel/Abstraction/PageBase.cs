using ISFramework;
using ISFramework.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ISFramework.PageObjectModel
{

    public abstract class PageBase
    {
        List<string> excludedGenericLinkTextList = new List<string>() { "log in", "sign up", "sign out" };
        public ITestDriver Driver { get; set; }
        public virtual string PageUrl { get { return Config.WebsiteURL; } }
        protected UIMap uiMap;
        protected PageBase(ITestDriver driver, UIMap uiMap)
        {
            Driver = driver;
            this.uiMap = uiMap;
        }

        public bool WaitUntil(Func<bool> condition, int maxWaitTimeInMilliseconds = -1)
        {
            return Driver.WaitUntil(condition, maxWaitTimeInMilliseconds);
        }
        public void ClickElements(string cssSelector, bool elementsExistOptional = false)
        {
            var elementCount = GetElements(cssSelector).Count;
            if (elementsExistOptional && elementCount == 0)
                return;

            Assert.Greater(elementCount, 0, "No clickable link is found.");
            for (int i = 0; i < elementCount; i++)
            {
                var element = GetElements(cssSelector)[i];
                if (element.Displayed && !excludedGenericLinkTextList.Contains(element.Text.ToLower()))
                {
                    var href = element.GetAttribute("href");
                    try
                    {
                        Driver.Click(element);
                    }
                    catch (Exception)
                    {
                        Driver.ClickViaJavascript(element);
                    }
                    Assert.IsTrue(Driver.URL.Contains(href), $"Page Url {Driver.URL} does not match the link href {href}");
                    Driver.OpenURL(PageUrl);
                }
            }
        }

        public virtual void ClickPrimaryButtons() { }
        public virtual void ClickSecondaryButtons() { }

        


        protected ReadOnlyCollection<IWebElement> GetElements(string cssSelector)
        {
            return Driver.FindElements(cssSelector);
          
        }

        
        }
    }

