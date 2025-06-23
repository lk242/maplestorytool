using Microsoft.AspNetCore.Mvc;
using MapleStoryTools.Models;
using System;

namespace MapleStoryTools.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ExperienceViewModel { StartTime = DateTime.Now, EndTime = DateTime.Now });
        }

        [HttpPost]
        public IActionResult Index(ExperienceViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.ExperienceGained = model.EndExperience - model.StartExperience;
                model.Minutes = (model.EndTime - model.StartTime).TotalMinutes;
                if (model.Minutes > 0)
                {
                    model.ExperiencePerMinute = model.ExperienceGained / model.Minutes;
                }
            }
            return View(model);
        }
    }
}
