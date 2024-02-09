using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp.Controllers; // Reemplazar con el namespace correcto de tu controlador

namespace MyApp.UnitTests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_Returns_View()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        // Agrega más métodos de prueba para cada acción del controlador que deseas probar
    }
}
