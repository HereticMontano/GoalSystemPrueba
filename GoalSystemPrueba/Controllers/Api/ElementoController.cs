using GoalSystemPrueba.Dato;
using GoalSystemPrueba.Models.Api;
using System.Web.Http;
using System;
using GoalSystemPrueba.Atributos;

namespace GoalSystemPrueba.Controllers.Api
{
    /// <summary>
    /// Clase que se encarga de la alta/baja de los elementos
    /// </summary>
    [Seguridad]
    public class ElementoController : ApiController
    {
        [HttpPost]
        public void AgregarElemento(ElementoModel elemento)
        {
            DatosElementos.FuenteDatos.Add(elemento);
        }

        [HttpPost]
        public int QuitarElemento([FromBody]string nombre)
        {
           return DatosElementos.FuenteDatos.RemoveAll(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
           
        }
    }
}