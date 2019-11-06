using GoalSystemPrueba.Provider;
using GoalSystemPrueba.Provider.Interface;
using System.Web.Http;
using System.Web.Mvc;
using Unity;

namespace GoalSystemPrueba
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IInventarioProvider, InventarioProvider>();

            DependencyResolver.SetResolver(new Unity.AspNet.Mvc.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}