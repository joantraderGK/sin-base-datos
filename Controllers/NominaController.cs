using Microsoft.AspNetCore.Mvc;
using Nomina.Clases;
using System.Collections.Generic;


namespace Nomina.Controllers
{
    public class NominaController : Controller
    {
        public IActionResult Index()
        {
            List<Nomina1> ListaNomina = new List<Nomina1>()
            {
                new Nomina1(){Sueldo_bruto=80000,Sueldo_neto=54328,Tss=5672 ,Isr=20000,Fecha_creación="12/4/2000",Fecha_nomina="Los dia 15 & 30"},
                new Nomina1(){Sueldo_bruto=90000,Sueldo_neto=65619,Tss=6381 ,Isr=18000,Fecha_creación="18/4/2001",Fecha_nomina="Los dia 15 & 30"},
                new Nomina1(){Sueldo_bruto=70000,Sueldo_neto=51037,Tss=4963 ,Isr=14000,Fecha_creación="17/4/2002",Fecha_nomina="Los dia 15 & 30"},
                new Nomina1(){Sueldo_bruto=60000,Sueldo_neto=43746,Tss=4254 ,Isr=12000,Fecha_creación="16/4/2003",Fecha_nomina="Los dia 15 & 30"},
                new Nomina1(){Sueldo_bruto=50000,Sueldo_neto=36455,Tss=3545 ,Isr=10000,Fecha_creación="14/4/2004",Fecha_nomina="Los dia 15 & 30"},
                new Nomina1(){Sueldo_bruto=40000,Sueldo_neto=54328,Tss=2836 ,Isr=8000,Fecha_creación="15/4/2005",Fecha_nomina="Los dia 15 & 30"}
            };

            ListaNomina = (from Nomina in ListaNomina
                           select Nomina).ToList();

            return View(ListaNomina);
        }

        public IActionResult Agregar()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Nomina1 onomina)
        {

            if (!ModelState.IsValid)
            {
                return View(onomina);
            }
            else
            {
                List<Nomina1> listaNomina = new List<Nomina1>();
                listaNomina.Add(onomina);
            }

            return RedirectToAction("Index");
        }
    }
}
