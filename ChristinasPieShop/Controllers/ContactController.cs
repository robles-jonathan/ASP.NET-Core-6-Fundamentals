using Microsoft.AspNetCore.Mvc;

namespace ChristinasPieShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
