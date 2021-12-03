using Complex742.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Threading.Tasks;
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
            Task<ViewResult> viewResult = controller.Index();
            Assert.NotNull(viewResult.Result);
        }

        [Fact]
        public void IndexViewNameEqualIndex()
        {
            var mock = new Mock<ILogger<HomeController>>();
            var imitationLogger = mock.Object;
            HomeController controller = new HomeController(imitationLogger);
            Task<ViewResult> viewResult = controller.Index();
            Assert.Equal("~/Views/Home/Index.cshtml", viewResult.Result.ViewName);
        }

    }
}
