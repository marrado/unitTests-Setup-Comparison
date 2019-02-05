using TechTalk.SpecFlow;

namespace SpecFlow.Comparison.Steps
{
    [Binding]
    public class Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            //Arrange
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //Act
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            //Assert
        }
    }
}
