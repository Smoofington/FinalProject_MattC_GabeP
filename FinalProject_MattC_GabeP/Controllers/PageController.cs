using FinalProject_MattC_GabeP.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace FinalProject_MattC_GabeP.Controllers
{
    public class PageController : Controller
    {
        private MattC_GabePContext context { get; }

        public PageController(MattC_GabePContext context)
        {
            this.context = context;
        }
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
            var ctx = context.Feedback.ToList();
            return View(ctx);
        }

    }
}
