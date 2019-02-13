using System;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace GoalSystemPrueba.Atributos
{
    [AttributeUsage(AttributeTargets.Class)]
    public class Seguridad: AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            return true;
        }
      
    }
}