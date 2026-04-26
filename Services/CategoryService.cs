using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services;

public class CategoryService(AppDbContext context) : ICategoryService
{
    public List<Category> GetCategory()
    {
        return context.Categories.ToList();
    }
}
