using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;

namespace Tracker.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void HomeControllerTest()
        {
            var controller = new HomeController(null);
            Assert.IsNotNull(controller);

        }

        [TestMethod()]
        public void IndexIsNotNullAndNotEqualsNotFoundTest()
        {
            var controller = new HomeController(null);
            var result = controller.Index() as ViewResult;
            Assert.AreNotEqual("NotFound", result.ViewName);
            Assert.IsNotNull(result.ViewData);
        }
    }
}