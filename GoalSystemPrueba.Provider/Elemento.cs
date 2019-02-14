using System;

namespace GoalSystemPrueba.Provider
{
    /// <summary>
    /// Entidad que representa los dato extraido de una consulta
    /// </summary>
    public class Elemento
    {
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public DateTime FechaCaducidad { get; set; }
    }
}
