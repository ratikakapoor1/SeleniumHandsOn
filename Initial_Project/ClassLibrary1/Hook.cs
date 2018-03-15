
using Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public sealed class Hooks
    {
//# for initial demo ONLY
//        [AfterScenario]
//        public static void AfterScenarioRun()

//        {
//            InitialDemoSpecs.CleanUp();
//        }



    //        [BeforeTestRun]
    //        public static void BeforeAutomationRun()
    //        {
    //            DriverInit.Initialize();
    //        }

        //        [AfterTestRun]
        //        public static void AfterAutomationRun()
        //        {

        //            DriverInit.Cleanup();
        //        }

        //        //[BeforeScenario]
        //        //public static void BeforeScenarioRun()
        //        //{
        //        //    Implement.OpenUrl(DriverInit.Driver, "about:blank");
        //        //    System.Threading.Thread.Sleep(1000);
        //        //}

        //        [AfterScenario]
        //        public static void AfterScenarioRun()
        //        {
        //            if (ScenarioContext.Current.TestError != null)
        //            {
        //                Console.WriteLine();
        //                //Console.WriteLine($"Test case failed on page: {WebManager.URL}");
        //            }
        //        }

    }
}
