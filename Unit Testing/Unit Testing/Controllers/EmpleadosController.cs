using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unit_Testing.Models;

namespace Unit_Testing.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Empleados
        public List<Empleados> GetEmpleado1()
        {
            return new List<Empleados>
            {
                new Empleados
                {
                    Nombre = "Alfredo",
                    Edad = 18
                },
           
            };
        }
        public List<Empleados> GetEmpleado2()
        {
            return new List<Empleados>
            {
                new Empleados
                {
                    Nombre = "Pablo",
                    Edad = 32
                }
            };
        }

        public ActionResult Index()
        {
            List<Empleados> empleados = this.GetEmpleado1();
            return View(empleados);
        }
        public ActionResult Index1()
        {
            List<Empleados> empleados = this.GetEmpleado2();
            return View(empleados);
        }

        public ActionResult Vistas()
        {
            ViewData["Nombre"] = "Mike Wasauski";
            ViewBag.Prueba = "Admin 123";
            return View(); 
        }
    }
}