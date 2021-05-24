using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Repositories;
using WebApplication6.Models;


namespace WebApplication6.Controllers
{
    public class UpdateUserController : Controller
    {
        UserRepository userRepository = new UserRepository();
        [HttpPost]
        public IActionResult Index(Login d)
        {
            var x = userRepository.TGet(d.id);
            x.Firstname = d.Firstname;
            x.Lastname = d.Lastname;
            x.Hours = DateTime.Now.ToString("dddd");
            x.Admin = d.Admin;
            x.Active = d.Active;
            x.Username = d.Username;
            x.Password = d.Password;
            userRepository.TUpdate(x);
            return RedirectToAction("Index", "User2");
        }
    }
}