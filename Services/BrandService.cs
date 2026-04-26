using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services;

public class BrandService(AppDbContext context) : IBrandService
{
    public List<Brand> GetBrands() =>  context.Brands.ToList();
}