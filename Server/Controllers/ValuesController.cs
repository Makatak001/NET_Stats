using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    public class ValuesController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}