using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Repositories;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class ShowUserController : Controller
    {
        UserRepository userRepository = new UserRepository();
        public IActionResult Index(int id)
        {
            var x = userRepository.TGet(id);
            Login ut = new Login()
            {
                id = x.id,
                Firstname = x.Firstname,
                Lastname = x.Lastname,
                Hours = x.Hours,
                Admin = x.Admin,
                Active = x.Active,
                Username = x.Username,
                Password = x.Password
            };
            return View(ut);
        }
    }
}