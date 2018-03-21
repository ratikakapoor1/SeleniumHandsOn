using NUnit.Framework;

namespace ISFramework
{
    public class TestBase
    {

        [SetUp]
        public void Initialize()
        {
            WebManager.Initialize();
        }
        

        [TearDown]
        public static void AfterAutomationRun()
        {
            WebManager.Cleanup();
        }
    }
}
