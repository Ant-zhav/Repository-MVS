using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Complex742.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace Complex742.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexViewNameEqualIndex()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.Equal("~/Views/Home/Index.cshtml", result?.ViewName);
        }
        [Fact]
        public void IndexViewNotNull()
        { 
            HomeController controller = new HomeController();
            ViewResult viewResult = controller.Index() as ViewResult;
            Assert.NotNull(viewResult?.ViewData);
        }
    }
}
