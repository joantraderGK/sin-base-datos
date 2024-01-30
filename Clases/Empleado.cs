using System.ComponentModel.DataAnnotations;
using Nomina.Controllers;
using Nomina.Models;
using System.Web;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.SignalR;




namespace Nomina.Clases
{
    public class Empleado
    {

        [Required]
        [Display(Name = "quiero el Id")]
        public  int Id { get; set; }
        
        [Required]
        [Display(Name = "quiero tu Nombre")]
        public string Nombre { get; set; }
       
        [Required]
        [Display(Name = "quiero tu apellido")]
        public string apellido { get; set;}
        [Range(1, 120, ErrorMessage = "Ingrese una edad válida")]
        [Required]
        [Display(Name = "quiero tu Edad")]
        public int Edad { get; set;}
         [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        
        [Display(Name = "quiero tu fecha_nacimiento")]
        public string fecha_nacimientos { get; set; }
        
        [Required]
        [Display(Name = "tipo de sexo")]
        public string sexo { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        [Display(Name = "quiero tu salario")]
        public decimal salario {  get; set; }
       
        [Required]
        [Display(Name = "quiero tu pais")]
        public string pais { get; set;}
        
        [Required]
        [Display(Name = "quiero tu provicia")]
        public string provincia { get; set;}
        
        [Required]
        [Display(Name = "quiero tu municipio")]
        public string municipio { get; set;}
        
        [Required]
        [Display(Name = "quiero tu barrios")]
        public string barrios { get; set;}
        
        [Required]
        [Display(Name = "quiero tu licencia")]
        public bool si_posee_licencia { get; set;}

       
    }
}