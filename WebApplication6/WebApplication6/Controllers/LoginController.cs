using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;
using System.Web;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace WebApplication6.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult>  Index(Login p)
        {
            var infos = c.Logins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if(infos != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Username)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Index");
            }
            return View();
        }
    }
}