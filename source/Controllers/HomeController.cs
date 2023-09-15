using kiemtra.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace kiemtra.Controllers
{
    public class HomeController : Controller
    {

        public static List<HomeProduct> products = new List<HomeProduct>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
            
        public IActionResult Index(bool? check = false)
        {
            if ((bool)check) 
            {
                products.Clear();
            }
            else
            {
                return View(products.ToList());
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(string tensanpham, int soluong, int dongia, double giamgia)
        {
            var homeProduct = new HomeProduct(tensanpham,soluong,dongia,giamgia);
            products.Add(homeProduct);
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}