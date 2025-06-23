using Microsoft.AspNetCore.Mvc;
using MapleStoryTools.Models;
using System;

namespace MapleStoryTools.Controllers
{
    public class ExpCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ExpCalcInput input)
        {
            var totalExp = input.EndExp - input.StartExp;
            var totalMinutes = (input.EndTime - input.StartTime).TotalMinutes;
            var expPerMinute = totalMinutes > 0 ? totalExp / totalMinutes : 0;

            ViewBag.TotalExp = totalExp;
            ViewBag.TotalMinutes = totalMinutes;
            ViewBag.ExpPerMinute = expPerMinute;

            return View();
        }
    }
}
