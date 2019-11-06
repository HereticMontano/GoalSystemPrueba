using GoalSystemPrueba.Atributos;
using GoalSystemPrueba.Models;
using GoalSystemPrueba.Provider.Interface;
using System.Web.Mvc;

namespace GoalSystemPrueba.Controllers
{
    [SeguridadAttribute]
    public class HomeController : Controller
    {
        private IInventarioProvider InventarioProv { get; set; }

        public HomeController(IInventarioProvider inventarioProvider)
        {
            InventarioProv = inventarioProvider;
        }

        public ActionResult Index()
        {
            var model = new HomeViewModel(InventarioProv.All());
            return View(model);
        }
    }
}