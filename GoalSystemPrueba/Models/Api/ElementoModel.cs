using GoalSystemPrueba.Enum;
using System;

namespace GoalSystemPrueba.Models.Api
{
    /// <summary>
    /// Clase que modela las propiedades de un elemento.
    /// </summary>
    public class ElementoModel
    {                
        public string Nombre { get; set; }
        public TipoElementoEnum Tipo { get; set; }        
        public DateTime FechaCaducidad { get; set; }               
    }
}