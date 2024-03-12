using Microsoft.AspNetCore.Mvc;
using ГК_PHP_ПЗ_Модуль_13_Laravel_ч_1.Models;

namespace ГК_PHP_ПЗ_Модуль_13_Laravel_ч_1.Controllers;

public class NewsController : Controller
{
    private readonly NewsDbContext _context;

    public NewsController(NewsDbContext context)
    {
        _context = context;
    }

    public IActionResult AddNew()
    {
        return View("AddNew");
    }


    [HttpPost]
    public IActionResult AddNew(News news)
    {
        if (ModelState.IsValid)
        {
            _context.News.Add(news);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        return View(news);
    }
}
