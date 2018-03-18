using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Implementation;

namespace ClassLibrary1
{
    [Binding]
    public class InitialDemoSteps

    {
        
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            InitialDemoSpecs.SetValues(p0);
      
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("adding numbers");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, InitialDemoSpecs.sum);
        }

    }
}
