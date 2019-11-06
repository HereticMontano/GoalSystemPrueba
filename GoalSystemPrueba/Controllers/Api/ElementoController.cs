using GoalSystemPrueba.Models.Api;
using System.Web.Http;
using GoalSystemPrueba.Atributos;
using GoalSystemPrueba.Provider;
using GoalSystemPrueba.Notifica;
using GoalSystemPrueba.Singleton;
using GoalSystemPrueba.Provider.Entity;
using GoalSystemPrueba.Provider.Interface;

namespace GoalSystemPrueba.Controllers.Api
{
    /// <summary>
    /// Clase que se encarga de la alta/baja de los elementos
    /// </summary>
    [SeguridadAttribute]
    public class ElementoController : ApiController
    {
        private IInventarioProvider InventarioProv;

        public ElementoController(IInventarioProvider inventarioProvider) //
        {
            InventarioProv = inventarioProvider;
        }

        [HttpPost]
        public void AgregarElemento(ElementoModel elemento)
        {
            InventarioProv.AgregarElemento(new Elemento { Nombre = elemento.Nombre, FechaCaducidad = elemento.FechaCaducidad, Tipo = (int)elemento.Tipo });
        }

        [HttpPost]
        public int QuitarElemento([FromBody]string nombre)
        {
            int cantidad = InventarioProv.EliminarPorNombre(nombre);

            //Asumo que seria practico que el metodo que quita elementos tambien lo notifique (pero esto deberi ir mas a la capa de negocio). 
            if (cantidad > 0)
                _ = NotificadorSingleton.GetInstance.NotificarEliminacionesAsync(nombre);

            return cantidad;
        }
    }
}