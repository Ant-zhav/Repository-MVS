using Complex742.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;


namespace Complex742.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexViewNotNull()
        {
            var mock = new Mock<ILogger<HomeController>>();
            var imitationLogger = mock.Object;
            HomeController controller = new HomeController(imitationLogger);
            ViewResult viewResult = controller.Index() as ViewResult;
            Assert.NotNull(viewResult?.ViewData);
        }

        [Fact]
        public void IndexViewNameEqualIndex()
        {
            var mock = new Mock<ILogger<HomeController>>();
            var imitationLogger = mock.Object;
            HomeController controller = new HomeController(imitationLogger);
            ViewResult result = controller.Index() as ViewResult;
            Assert.Equal("~/Views/Home/Index.cshtml", result?.ViewName);
        }

    }
}
