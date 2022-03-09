using KonusarakOgren.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgren.WEB.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User User)
        {
          
            return View();
        }
    }
}
