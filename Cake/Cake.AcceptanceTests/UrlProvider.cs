using System;

namespace Cake.AcceptanceTests
{
    public static class UrlProvider
    {
        public static readonly string ApplicationBaseUrl;

        static UrlProvider()
        {
            var applicationEnvironmentVariable = Environment.GetEnvironmentVariable("CAKE_TEST_URL");
            ApplicationBaseUrl = "http://localhost:58369";
            if (!string.IsNullOrWhiteSpace(applicationEnvironmentVariable))
            {
                ApplicationBaseUrl = applicationEnvironmentVariable;
            }
        }
    }
}