using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ISFramework;

namespace ISFeatureFile
{
    [Binding]
    public sealed class HooksFile
    {
        [BeforeScenario]
        public void Initialize()
        {
            WebManager.Initialize();
        }


        [AfterScenario]
        public static void AfterAutomationRun()
        {
            WebManager.Cleanup();
        }
    }
}
