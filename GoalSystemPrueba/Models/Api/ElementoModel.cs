using GoalSystemPrueba.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace GoalSystemPrueba.Models.Api
{
    public class ElementoModel
    {        
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        public TipoElementoEnum Tipo { get; set; }
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime FechaCaducidad { get; set; }       
        public bool Caducado { get { return FechaCaducidad <= DateTime.Now; } }
    }
}