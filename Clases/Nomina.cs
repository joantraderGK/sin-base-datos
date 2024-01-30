using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.SignalR;
using Nomina.Models;




namespace Nomina.Clases
      
    
{
    public class Nomina1
    {
        [Required]
        [Display(Name = "Ingresar el sueldo")]
        public decimal Sueldo_bruto {  get; set; }
        
        [Required]
        [Display(Name = "Ingresar el sueldo_neto")]
        public decimal Sueldo_neto { get; set; }
        
        [Required]
        [Display(Name = "Ingresar el Tss")]
        public decimal Tss { get; set; }
        
        [Required]
        [Display(Name = "Ingresar el Isr")]
        public decimal Isr { get; set; }

        [Required]
        [Display(Name = "Ingresar la fecha_creación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Fecha_creación { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        [Display(Name = "ingresar tu Fecha_nomina")]
        public string Fecha_nomina { get; set; }

    }
}
