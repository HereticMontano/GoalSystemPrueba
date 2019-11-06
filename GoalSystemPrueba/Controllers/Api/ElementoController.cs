using GoalSystemPrueba.Atributos;
using GoalSystemPrueba.Models.Api;
using GoalSystemPrueba.Provider.Entity;
using GoalSystemPrueba.Provider.Interface;
using GoalSystemPrueba.Singleton;
using System.Web.Http;

namespace GoalSystemPrueba.Controllers.Api
{
    /// <summary>
    /// Clase que se encarga de la alta/baja de los elementos
    /// </summary>
    [SeguridadAttribute]
    public class ElementoController : ApiController
    {
        private IInventarioProvider InventarioProv;

        public ElementoController(IInventarioProvider inventarioProvider)
        {
            InventarioProv = inventarioProvider;
        }

        [HttpPost]
        public IHttpActionResult AgregarElemento(ElementoModel elemento)
        {
            if (ModelState.IsValid)
            {
                InventarioProv.AgregarElemento(new Elemento { Nombre = elemento.Nombre, FechaCaducidad = elemento.FechaCaducidad, Tipo = (int)elemento.Tipo });
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        public IHttpActionResult QuitarElemento([FromBody]string nombre)
        {
            int cantidad = InventarioProv.EliminarPorNombre(nombre);

            //Asumo que seria practico que el metodo que quita elementos tambien lo notifique (pero esto deberi ir mas a la capa de negocio). 
            if (cantidad > 0)
                _ = NotificadorSingleton.GetInstance.NotificarEliminacionesAsync(nombre);

            return Ok(cantidad);
        }
    }
}