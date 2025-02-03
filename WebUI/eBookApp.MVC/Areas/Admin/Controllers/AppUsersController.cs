using eBookApp.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBookApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AppUsersController : Controller
    {
        private readonly AppDbContext _context;

        public AppUsersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.AppUsers.ToListAsync());
        }
    }
}