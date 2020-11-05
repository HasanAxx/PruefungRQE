using System;
using TechTalk.SpecFlow;
using Xunit;

namespace PruefungRQE
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double number, taken;
        [Given(@"the first number is PI")]
        public void GivenTheFirstNumberIsPI()
        {
            number = Math.PI;
        }
        
        [When(@"sinus is taken from this number")]
        public void WhenSinusIsTakenFromThisNumber()
        {
            taken = Math.Sin(number);
        }
        
        [When(@"cosinus is taken from this number")]
        public void WhenCosinusIsTakenFromThisNumber()
        {
            taken = Math.Cos(number);
        }
        
        [When(@"tangens is taken from this number")]
        public void WhenTangensIsTakenFromThisNumber()
        {
            taken = Math.Tan(number);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            Assert.Equal(p0, taken, 5);
            
        }
    }
}
