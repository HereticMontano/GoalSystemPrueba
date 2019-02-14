using GoalSystemPrueba.Models;
using GoalSystemPrueba.Provider;
using System.Web.Mvc;

namespace GoalSystemPrueba.Controllers
{
    public class HomeController : Controller
    {
        private InventarioProvider InventarioProv;

        public HomeController()
        {
            InventarioProv = new InventarioProvider();
        }

        public ActionResult Index()
        {
            var model = new HomeViewModel(InventarioProv.All());
            return View(model);
        }
    }
}