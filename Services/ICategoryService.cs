using WebApplication.Models;

namespace WebApplication.Services;

public interface ICategoryService
{
    public List<Category> GetCategory();
}