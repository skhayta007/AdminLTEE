using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class IndexController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}