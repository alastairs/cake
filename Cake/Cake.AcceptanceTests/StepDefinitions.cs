using TechTalk.SpecFlow;

namespace Cake.AcceptanceTests
{
    [Binding]
    public class StepDefinitions
    {
        [When("I visit the home page")]
        public void WhenIVisitTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then("I should see an? '(.*)' button")]
        public void ThenTheResultShouldBe(string buttonText)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
