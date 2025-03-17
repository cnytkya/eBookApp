using eBookApp.EntityLayer.Entities;

namespace eBookApp.MVC.Areas.Customer.ViewModels
{
    public class HomePageViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Books> Books { get; set; }
        public List<News> News { get; set; }
    }
}