using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;
using WebApplication6.Repositories;

namespace WebApplication6.Controllers
{
    public class DeleteUserController : Controller
    {
        UserRepository userRepository = new UserRepository();

        public IActionResult Index(int id)
        {
            userRepository.TDelete(new Login { id = id});
            return RedirectToAction("Index", "User2");
        }
    }
}