using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgren.WEB.Controllers
{
    public class Quiz : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
