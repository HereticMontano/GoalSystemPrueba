using GoalSystemPrueba.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace GoalSystemPrueba.Models.Api
{
    /// <summary>
    /// Clase que modela las propiedades de un elemento.
    /// </summary>
    public class ElementoModel
    {
        [Required(ErrorMessage = "Campo {0} obligatorio")]
        public string Nombre { get; set; }
        public TipoElementoEnum Tipo { get; set; }        
        public DateTime FechaCaducidad { get; set; }               
    }
}