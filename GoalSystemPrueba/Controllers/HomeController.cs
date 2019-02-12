using GoalSystemPrueba.Models;
using System.Web.Mvc;

namespace GoalSystemPrueba.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View(new HomeViewModel());
        }       
    }
}