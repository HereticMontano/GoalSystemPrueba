using GoalSystemPrueba.Dato;
using GoalSystemPrueba.Models.Api;
using System.Web.Http;
using System.Web.Mvc;

namespace GoalSystemPrueba.Controllers.Api
{
    public class ElementoController : ApiController
    {        

        public void AgregarElemento(ElementoModel elemento)
        {
            DatosElementos.FuenteDatos.Add(elemento);
        }

        public JsonResult QuitarElemento(string nombre)
        {

            return new JsonResult();
        }
    }
}