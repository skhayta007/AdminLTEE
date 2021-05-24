using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Repositories;

namespace WebApplication6.Controllers
{
    public class User2Controller : Controller
    {
        UserRepository userRepository = new UserRepository();

        public IActionResult Index()
        {
            

            return View(userRepository.TList());
        }
    }
}