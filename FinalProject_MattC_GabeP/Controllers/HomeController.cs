using FinalProject_MattC_GabeP.Models;
using FinalProject_MattC_GabeP.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_MattC_GabeP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MattC_GabePContext context { get; }

        public HomeController(ILogger<HomeController> logger, MattC_GabePContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ActionResult Save()
        {
            return View("Feedback", new FeedbackViewModel() { FeedbackName = "", FeedbackText = ""});
        }

        [HttpPost]
        public IActionResult Saving(FeedbackViewModel feedback)
        {
            context.Feedback.Add(feedback);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
