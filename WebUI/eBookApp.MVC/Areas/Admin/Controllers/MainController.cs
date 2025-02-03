using Microsoft.AspNetCore.Mvc;

namespace eBookApp.MVC.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}