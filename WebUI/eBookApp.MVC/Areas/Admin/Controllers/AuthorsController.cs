using eBookApp.DataAccessLayer;
using eBookApp.EntityLayer.Entities;
using eBookApp.MVC.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBookApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorsController : BaseController
    {
        private readonly AppDbContext _context;

        public AuthorsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //var authors = await _context.Authors.ToListAsync();
            return View(await _context.Authors.ToListAsync());
        }

        //GET: Admin/Authors/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Author author, IFormFile? Img)
        {
            if (ModelState.IsValid)
            {
                author.Img = await FileHelper.FileUploader(Img);
                _context.Add(author);
                await _context.SaveChangesAsync();
                SetNotification("Yazar başarıyla eklendi.", "success");
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        //GET: Admin/Authors/Update/5
        public async Task<IActionResult> Update()
        {
            return View();
        }
    }
}