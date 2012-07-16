using System.Web.Mvc;
using Cake.WebApp.Controllers;
using NUnit.Framework;

namespace Cake.WebApp.Tests.Controllers
{
    [TestFixture]
    public sealed class HomeControllerTests
    {
        [Test]
        public void TestThat_Index_Should_RenderView()
        {
            var controller = new HomeController();

            ActionResult result = controller.Index();

            Assert.That(result, Is.InstanceOf<ViewResult>());
        }
    }
}
