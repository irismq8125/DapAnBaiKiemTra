using kiemtra.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;

namespace kiemtra.Controllers
{
    public class ContactController : Controller
    {
           
        public IActionResult Index()
        {
            ViewData["HoTen"] = "Huỳnh Mậu Quý";
            ViewData["NgaySinh"] = "04/17/1993";
            ViewData["Email"] = "mauquy123@gmail.com";
            ViewData["SDT"] = "0379112419";
            return View();
        }
    }
}
