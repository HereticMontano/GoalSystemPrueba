using GoalSystemPrueba.Enum;
using GoalSystemPrueba.Models.Api;
using System;
using System.Collections.Generic;

namespace GoalSystemPrueba.Dato
{
    /// <summary>
    /// Mock de elementos en el inventario
    /// </summary>
    public static class DatosElementos
    {
        private static List<ElementoModel> fuenteDatos = new List<ElementoModel>
        {
            new ElementoModel { Nombre = "Velador", Tipo = TipoElementoEnum.Iluminacion, FechaCaducidad = DateTime.Parse("22/08/19")},
            new ElementoModel { Nombre = "Cuadro", Tipo = TipoElementoEnum.Decoracion, FechaCaducidad = DateTime.Parse("16/01/22")},
            new ElementoModel { Nombre = "Mesa", Tipo = TipoElementoEnum.Muebles, FechaCaducidad = DateTime.Parse("09/12/08") }
        };

        public static List<ElementoModel> FuenteDatos
        {
            get { return fuenteDatos; }
        }
    }
}