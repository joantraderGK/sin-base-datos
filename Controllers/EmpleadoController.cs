using Microsoft.AspNetCore.Mvc;
using Nomina.Clases;
using Nomina.Models;
using NuGet.Packaging;
using System.Collections.Generic;
using System.Net;

namespace Nomina.Controllers
{
    public class EmpleadoController : Controller
    {
        //List<Empleado> ListaEmpleado;
        public  List<Empleado> ListaEmpleado = new List<Empleado>();

        public IActionResult Index()
        {
            // new List<Empleado
            ListaEmpleado.Add
                
                ( 

           
                new Empleado(){Id=12,Nombre="wally",apellido="Martínez",Edad=29,fecha_nacimientos="12/9/1994",sexo="Masculino",salario=80000,pais="RD",provincia="santo domnigo",municipio="santo domingo oeste",barrios="managuayabo",si_posee_licencia=true}
                //new Empleado(){Id=15,Nombre="Dios",apellido="cristo",Edad=35,fecha_nacimientos="11/2/1992",sexo="Masculino",salario=90000,pais="RD",provincia="santo Domingo",municipio="santo domingo oeste",barrios="mana guayabo",si_posee_licencia=true},
               // new Empleado(){Id=16,Nombre="pedro",apellido="pimente",Edad=55,fecha_nacimientos="13/4/1993",sexo="Masculino",salario=70000,pais="RD",provincia="santo domnigo",municipio="santo domingo oeste",barrios="bayona",si_posee_licencia=false}
                //new Empleado(){Id=18,Nombre="Joan",apellido="Rodriguez",Edad=45,fecha_nacimientos="16/9/1996",sexo="Masculino",salario=60000,pais="RD",provincia="santo domnigo",municipio="santo domingo este",barrios="la caoba",si_posee_licencia=false},
                //new //Empleado(){Id=19,Nombre="Kaisaris",apellido="Gaston",Edad=66,fecha_nacimientos="18/9/1997",sexo="femenina",salario=50000,pais="RD",provincia="santo domnigo",municipio="santo domingo este",barrios="san isidro",si_posee_licencia=true},
                //new Empleado(){Id=20,Nombre="ana",apellido="Gaston",Edad=28,fecha_nacimientos="19/9/1998",sexo="femenina",salario=30000,pais="RD",provincia="santo domnigo",municipio="santo domingo este",barrios="mameyes",si_posee_licencia=false}
               
           );

            ListaEmpleado.Add(new Empleado() { Id = 18, Nombre = "Joan", apellido = "Rodriguez", Edad = 45, fecha_nacimientos = "16/9/1996", sexo = "Masculino", salario = 60000, pais = "RD", provincia = "santo domnigo", municipio = "santo domingo este", barrios = "la caoba", si_posee_licencia = false });


          var  listaEmpleado = (from Empleado in ListaEmpleado
                             select Empleado).ToList();

            return View(listaEmpleado);
        }

        public IActionResult AgregarEmpleado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarEmpleado(Empleado oEmpleado)
        {
            if (!ModelState.IsValid)
            {
                return View (oEmpleado);
            }
            else
            {


                ListaEmpleado.Add(new ()
                {
                    Id = oEmpleado.Id,
                    Nombre = oEmpleado.Nombre,
                    apellido  = oEmpleado.apellido,
                    Edad = oEmpleado.Edad,
                    fecha_nacimientos  = oEmpleado.fecha_nacimientos,
                    sexo = oEmpleado.sexo,
                    salario = oEmpleado.salario,
                    pais = oEmpleado.pais,
                    provincia = oEmpleado.provincia,
                    municipio = oEmpleado.municipio,
                    barrios = oEmpleado.barrios,
                    si_posee_licencia = oEmpleado.si_posee_licencia


                });
                // return RedirectToAction("Index","Empleado") ;
                //     RedirectToAction("Index", "Empleado");

             //   var lista = ListaEmpleado;
                return RedirectToAction ("Index","Empleado");
                
            }
           
        }    

    }
}
