using System.Web;
using System.Web.Mvc;

namespace MvcProva.Controllers
{
    public class HelloWorldController : Controller
    {
       
        public ActionResult Index()
        {
            return View ();
        }

        
        public ActionResult Welcome(string nome, int Num = 1)
        {
            ViewBag.Message = "Olá " + nome;
            ViewBag.Num = Num;

            return View();
        }
    }
}