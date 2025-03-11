using Microsoft.AspNetCore.Mvc;

namespace eBookApp.MVC.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ContactController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}