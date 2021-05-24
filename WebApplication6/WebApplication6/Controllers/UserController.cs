using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class UserController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Logins.ToList();
            return View(values);
        }
        
    }
}