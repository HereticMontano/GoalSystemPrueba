using GoalSystemPrueba.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace GoalSystemPrueba.Models.Api
{
    public class ElementoModel
    {                
        public string Nombre { get; set; }
        public TipoElementoEnum Tipo { get; set; }        
        public DateTime FechaCaducidad { get; set; }       
        public bool Caducado { get { return FechaCaducidad <= DateTime.Now; } }
    }
}