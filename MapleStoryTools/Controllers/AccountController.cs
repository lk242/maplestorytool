using Microsoft.AspNetCore.Mvc;
using MapleStoryTools.Models;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Http;
using System;

namespace MapleStoryTools.Controllers
{
    public class AccountController : Controller
    {
        private static List<User> Users = new List<User>();

        public IActionResult Register() => View();
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            string hash = Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password)));
            Users.Add(new User { Username = username, PasswordHash = hash });
            TempData["Message"] = "註冊成功，請登入";
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            string hash = Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password)));
            var user = Users.Find(u => u.Username == username && u.PasswordHash == hash);
            if (user != null)
            {
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Index", "Home");
            }
            TempData["Error"] = "登入失敗";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
