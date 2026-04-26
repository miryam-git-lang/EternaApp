using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services;

public class PortfolioService(AppDbContext context) : IPortfolioService
{
    public List<Portfolio> GetPortfolio() => 
        [.. context.Portfolios.Include(p => p.PortfolioImages)];

    public Portfolio GetPortfolioById(int id)
    {
        return context.Portfolios.FirstOrDefault(p => p.Id == id) ?? throw new ArgumentException($"Portfolio with id {id} not found");
    }
}