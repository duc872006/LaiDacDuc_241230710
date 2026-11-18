using LaiDacDuc_241230710.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LaiDacDuc_241230710.Controllers
{
 
    public class HomeController : Controller
    {
        private readonly QlnhaSachContext _db;
        public HomeController(QlnhaSachContext db) => _db = db;
        public IActionResult Index()
        {
            var ds = _db.Saches.Where(s => s.Gia != null & s.Gia >= 100).ToList();
            ViewData["TieuDe"] = "Lai Dac Duc";
            return View(ds);
        }
     

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
