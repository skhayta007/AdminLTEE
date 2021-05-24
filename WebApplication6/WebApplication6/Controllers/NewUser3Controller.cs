using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Repositories;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class NewUser3Controller : Controller
    {
        UserRepository userRepository = new UserRepository();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Login p)
        {
            p.Active = 1;
            p.Admin = 1;
            p.Hours = DateTime.Now.ToString("dddd");
            userRepository.TAdd(p);
            return RedirectToAction("Index", "User2");
        }
    }
}