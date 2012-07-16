using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Cake.AcceptanceTests
{
    public static class WebDriverExtensions
    {
        public static void NavigateTo(this IWebDriver webDriver, string relativeUrl)
        {
            var fullUrl = UrlProvider.ApplicationBaseUrl + relativeUrl;
            webDriver.Url = fullUrl;
        }

        public static void AssertElementIsVisible(this ISearchContext searchContext, string cssSelector)
        {
            IWebElement element = searchContext.Find(cssSelector);
            Assert.That(element.Displayed, Is.True);
        }

        public static IWebElement Find(this ISearchContext searchContext, string cssSelector)
        {
            return searchContext.FindElement(By.CssSelector(cssSelector));
        }

        public static IEnumerable<IWebElement> FindAll(this ISearchContext searchContext, string cssSelector)
        {
            return searchContext.FindElements(By.CssSelector(cssSelector));
        } 
    }
}