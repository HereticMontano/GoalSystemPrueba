using System;
using GoalSystemPrueba.Controllers.Api;
using GoalSystemPrueba.Models.Api;
using GoalSystemPrueba.Provider;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoalSystemPrueba.Test
{
    [TestClass]
    public class WebApiTest
    {
        [TestMethod]
        public void AltaElemento()
        {
            InventarioProvider provider = new InventarioProvider();
            var cantidadElementosInicio = provider.All().Count;

            ElementoController elemento = new ElementoController();

            elemento.AgregarElemento(new ElementoModel { Nombre = "Test", Tipo = Enum.TipoElementoEnum.Iluminacion, FechaCaducidad = DateTime.Now });

            Assert.AreNotSame(cantidadElementosInicio, provider.All().Count);
        }

        public void BajaElemento()
        {
            InventarioProvider provider = new InventarioProvider();
            var cantidadElementosInicio = provider.All().Count;

            ElementoController elemento = new ElementoController();

            elemento.QuitarElemento("Cuadro");

            Assert.AreNotSame(cantidadElementosInicio, provider.All().Count);
        }
    }
}
