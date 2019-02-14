using System;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace GoalSystemPrueba.Atributos
{
    /// <summary>
    /// El atributo que administra los accesos a la clase
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class SeguridadAttribute: AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            return true;
        }
      
    }
}