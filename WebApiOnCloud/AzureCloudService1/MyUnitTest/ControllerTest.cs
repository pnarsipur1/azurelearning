using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using WebRole1;
using WebRole1.Controllers;

namespace MyUnitTest
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act

            ViewResult result = controller.Index("a") as ViewResult;


            //Assert

           Assert.AreEqual(result.ViewName,"valid");
        }
    }
}
