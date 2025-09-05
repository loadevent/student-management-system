using Jet_Skills_SMS_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jet_Skills_SMS_.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly JetSkillsDbContext _dbContext;
        public AdminController(JetSkillsDbContext context)
        {
            _dbContext = context;
        }
        public IActionResult Dashboard()
        {
            ViewBag.yourName = "Kabelo";
            return View();
        }
    }
}
