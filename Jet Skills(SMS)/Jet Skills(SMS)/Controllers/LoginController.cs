using Jet_Skills_SMS_.Models;
using Jet_Skills_SMS_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Jet_Skills_SMS_.Controllers
{
    public class LoginController : Controller
    {
        private readonly JetSkillsDbContext _dbContext;
        private List<UserType> userTypes;

        public LoginController(JetSkillsDbContext context) {
            _dbContext = context;
            userTypes = _dbContext.UserTypes.ToList();

        }
        [HttpGet]
        public IActionResult Login()
        {
            
            ViewBag.userTypes = new SelectList(userTypes, "UserTypeId", "Description");

            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection collection)
        {
            ViewBag.userTypes = new SelectList(userTypes, "UserTypeId", "Description");

            int username = Convert.ToInt32(collection["UserId"]);
            string? password = collection["Password"];
            int userType = Convert.ToInt32(collection["userType"]);

            AllUser? user = _dbContext.AllUsers
                .Where(u => u.UserId == username && u.Password == password && u.UserType == userType)
                .FirstOrDefault();

            if (user == null)
            {
                ViewBag.error = "Invalid Login Credentials";
                return View();
            }

            //ViewBag.userType = userType;
            return RedirectToAction("Index", "Home", user);
        }





    }
}
