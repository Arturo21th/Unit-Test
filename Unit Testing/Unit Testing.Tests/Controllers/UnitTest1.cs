using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Testing.Controllers;
using System.Web.Mvc;

namespace Unit_Testing.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIndex()
        {
            Empleados controlador = new Empleados();

            ViewResult result = controlador.Index() as ViewResult;
            ViewResult result1 = controlador.Index1() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreNotEqual(result, result1);
            

        }
        [TestMethod]
        public void VistaTest()
        {
            Empleados controlador = new Empleados();

            ViewResult result = controlador.Vistas() as ViewResult;
            
            Assert.AreEqual("Walter White", result.ViewData["Nombre"]);
            Assert.AreEqual("Jesse Pinkman", result.ViewBag.Prueba);

        }
    }
}
