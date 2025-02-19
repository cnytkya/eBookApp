using Microsoft.AspNetCore.Mvc;

namespace eBookApp.MVC.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected void SetNotification(string message, string type = "success")
        {
            TempData["NotificationMessage"] = message;
            TempData["NotificationType"] = type; //"success","warning","danger"
        }
    }
}