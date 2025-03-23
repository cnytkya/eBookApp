using eBookApp.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBookApp.MVC.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class BooksController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public BooksController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _appDbContext.Books.Where(b => b.IsActive).Include(b => b.Author).Include(b => b.Category).ToListAsync();//sadece mevcut olan yani mağazada olmayan kitaplar listeşenmesin istiyorsak Where(b=>b.IsActive) ifadesini kullanırız.
            return View(books);
        }

        // GET: Admin/Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var books = await _appDbContext.Books
                .Include(b => b.Author)
                .Include(b => b.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (books == null)
            {
                return NotFound();
            }

            return View(books);
        }
    }
}