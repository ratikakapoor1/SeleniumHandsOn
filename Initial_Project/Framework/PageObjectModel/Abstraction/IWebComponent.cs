using System;

namespace ISFramework.PageObjectModel
{
    public interface IWebComponent
    {
        string PageUrl { get; }
        bool IsVisible { get; }
        bool WaitUntil(Func<bool> condition, int maxWaitTimeInMilliseconds = -1);
        void ClickPrimaryButtons();
        void ClickSecondaryButtons();
    }
}
