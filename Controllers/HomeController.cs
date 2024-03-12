using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ГК_PHP_ПЗ_Модуль_13_Laravel_ч_1.Models;

namespace ГК_PHP_ПЗ_Модуль_13_Laravel_ч_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewsDbContext _context;

        public HomeController(NewsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var newsList = _context.News.ToList();
            return View(newsList);
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
