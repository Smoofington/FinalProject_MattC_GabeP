using FinalProject_MattC_GabeP.Models;
using FinalProject_MattC_GabeP.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_MattC_GabeP.Controllers
{
    public class FeedbackController : Controller
    {
        private FeedbackUnit data { get; set; }
        public FeedbackController(MattC_GabePContext ctx) => data = new FeedbackUnit(ctx);


        [HttpGet]
        public ViewResult Add()
        {
            this.LoadViewBag("Add");
            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            this.LoadViewBag("Edit");
            var f = this.GetFeedback(id);
            return View("Add", f);
        }

        public IActionResult Add(FeedbackViewModel f)
        {
            if (ModelState.IsValid)
            {
                if (f.FeedbackId == 0)
                    data.Feedback.Insert(f);
                else
                    data.Feedback.Update(f);
                data.Feedback.Save();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                string operation = (f.FeedbackId == 0) ? "Add" : "Edit";
                this.LoadViewBag(operation);
                return View();
            }
        }

        public ViewResult Delete(int id)
        {
            var f = this.GetFeedback(id);
            return View();
        }

        private FeedbackViewModel GetFeedback(int id)
        {
            var feedbackOptions = new QueryOptions<FeedbackViewModel>
            {
                Includes = "FeedbackName, FeedbackText",
                Where = f => f.FeedbackId == id
            };
            return data.Feedback.Get(feedbackOptions);
        }

        private void LoadViewBag(string operation)
        {
            ViewBag.Feedback = data.Feedback.List(new QueryOptions<FeedbackViewModel>
            {
                OrderBy = f => f.FeedbackId
            });
            ViewBag.Operation = operation;
        }
    }
}
