using GoalSystemPrueba.Models.Api;
using System.Web.Http;
using GoalSystemPrueba.Atributos;
using GoalSystemPrueba.Provider;
using GoalSystemPrueba.Notifica;

namespace GoalSystemPrueba.Controllers.Api
{
    /// <summary>
    /// Clase que se encarga de la alta/baja de los elementos
    /// </summary>
    [SeguridadAttribute]
    public class ElementoController : ApiController
    {
        private InventarioProvider InventarioProv;

        public ElementoController()
        {
            InventarioProv = new InventarioProvider();
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

            //Asumo que seria practico que el metodo que quita elementos tambien lo notifique. 
            if (cantidad > 0)
            {
                Notificador notificador = new Notificador("http://www.ejemplo.com");
                notificador.NotificarEliminaciones(nombre).Wait();
            }

            return cantidad;
        }
    }
}