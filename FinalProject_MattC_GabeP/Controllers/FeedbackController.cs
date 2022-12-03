using FinalProject_MattC_GabeP.Models;
using FinalProject_MattC_GabeP.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace FinalProject_MattC_GabeP.Controllers
{
    public class FeedbackController : Controller
    {
        private Repository<FeedbackViewModel> feedback { get; set; }
        public FeedbackController(MattC_GabePContext ctx) => feedback = new Repository<FeedbackViewModel>(ctx);

        public ViewResult Index()
        {
            var options = new QueryOptions<FeedbackViewModel>
            {
                OrderBy = f => f.FeedbackName
            };
            return View(feedback.List(options));
        }

        [HttpGet]
        public ViewResult Add() => View();

        [HttpPost]
        public IActionResult Add(FeedbackViewModel feedbackVM)
        {
            if (ModelState.IsValid)
            {
                feedback.Insert(feedbackVM);
                feedback.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(feedback);
            }
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            return View(feedback.Get(id));
        }

        [HttpPost]
        public RedirectToActionResult Delete(FeedbackViewModel feedbackVM)
        {
            feedback.Delete(feedbackVM);
            feedback.Save();
            return RedirectToAction("Index");
        }
    }
}
