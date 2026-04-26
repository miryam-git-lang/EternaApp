using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services;

public class ServiceService(AppDbContext context) : IServiceService
{
    public List<Service> GetServices() => context.Services.ToList();
    
}