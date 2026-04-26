using WebApplication.Models;

namespace WebApplication.Services;

public interface IBrandService
{
    public List<Brand> GetBrands();
}