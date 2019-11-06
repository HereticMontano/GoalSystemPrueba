using System;
using System.Collections.Generic;

namespace GoalSystemPrueba.Provider
{
    /// <summary>
    /// El provider de la "tabla" en base de inventario
    /// </summary>
    public class InventarioProvider
    {
        private static List<Elemento> Mock = new List<Elemento>
        {
            new Elemento { Nombre = "Velador", Tipo = 1, FechaCaducidad = DateTime.Parse("22/08/19")},
            new Elemento { Nombre = "Cuadro", Tipo = 2, FechaCaducidad = DateTime.Parse("16/01/22")},
            new Elemento { Nombre = "Mesa", Tipo = 3, FechaCaducidad = DateTime.Parse("09/12/08") }
        };

        public List<Elemento> All()
        {
            return Mock;
        }

        public void AgregarElemento(Elemento elemento)
        {
            All().Add(elemento);
        }

        public int EliminarPorNombre(string nombre)
        {
            return All().RemoveAll(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
    }
}

