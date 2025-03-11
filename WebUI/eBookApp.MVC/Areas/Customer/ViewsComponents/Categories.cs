using eBookApp.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBookApp.MVC.Areas.Customer.ViewsComponents
{
    public class Categories : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public Categories(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _appDbContext.Categories.ToListAsync());
        }
    }
}