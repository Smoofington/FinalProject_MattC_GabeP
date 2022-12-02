using Microsoft.AspNetCore.Mvc;

namespace FinalProject_MattC_GabeP.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Gabe()
        {
            return View();
        }

        public IActionResult Matt()
        {
            return View();
        }

        public IActionResult GabeHobby()
        {
            return View();
        }

        public IActionResult MattHobby()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            return View();
        }

    }
}
