using Jet_Skills_SMS_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jet_Skills_SMS_.Controllers
{
    public class LoginController : Controller
    {
        JetSkillsDbContext db = new JetSkillsDbContext();
        public LoginController() { }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection collection)
        {
            //List<UserType> userTypes = db.UserTypes.ToList();
            //ViewBag.userTypes = userTypes;

            int username = Convert.ToInt32(collection["username"]);
            string password = collection["password"];
            int userType = Convert.ToInt32(collection["userType"]);

            var user = db.Students.Where(u => u.StudentId == username && u.Password == password && u.UserType == 3).FirstOrDefault();

            if (user == null)
            {
                ViewBag.error = "Invalid Login Credentials";
                return View();
            }

            return RedirectToAction("Index", "Home");
        }





    }
}
