using Jet_Skills_SMS_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jet_Skills_SMS_.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(String username, String password)
        {
            return View();
        }//0877301166





    }
}
