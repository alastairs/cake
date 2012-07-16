using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace Cake.AcceptanceTests
{
    [Binding]
    public class StepDefinitions
    {
        private IWebDriver webDriver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            webDriver = new FirefoxDriver();
            ITimeouts timeouts = webDriver.Manage().Timeouts();
            timeouts.SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            timeouts.SetScriptTimeout(TimeSpan.FromSeconds(5));
            timeouts.ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webDriver.Quit();
        }

        [When("I visit the home page")]
        public void WhenIVisitTheHomePage()
        {
            webDriver.NavigateTo("/");
        }

        [Then("I should see an? '(.*)' button")]
        public void ThenTheResultShouldBe(string buttonText)
        {
            IWebElement button = webDriver.Find("a.button");

            Assert.That(button.Text, Is.EqualTo(buttonText));
        }
    }
}
