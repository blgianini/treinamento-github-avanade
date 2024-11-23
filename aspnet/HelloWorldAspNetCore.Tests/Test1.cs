using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using HelloWorldAspNetCore.Controllers;

namespace HelloWorldAspNetCore.Tests
{
    [TestClass]
    public class HelloWorldControllerTests
    {
        [TestMethod]
        public void Get_ReturnsHelloWorld()
        {
            // Arrange
            var controller = new HelloWorldController();

            // Act
            var result = controller.Get();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual("Hello World!", okResult.Value);
        }
    }
}
