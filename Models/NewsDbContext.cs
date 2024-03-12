using Microsoft.EntityFrameworkCore;

namespace ГК_PHP_ПЗ_Модуль_13_Laravel_ч_1.Models;

public class NewsDbContext : DbContext
{
    public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options)
    {
    }
    public DbSet<News> News { get; set; }
}
