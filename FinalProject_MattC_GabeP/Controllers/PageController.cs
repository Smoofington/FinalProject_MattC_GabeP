using Microsoft.AspNetCore.Mvc;

namespace FinalProject_MattC_GabeP.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
