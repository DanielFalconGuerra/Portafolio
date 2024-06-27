using Microsoft.AspNetCore.Mvc;

namespace Portafolio.Controllers
{
    public class SportsAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
