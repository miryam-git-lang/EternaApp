using WebApplication.Models;

namespace WebApplication.Services;

public interface IPortfolioService
{ 
    public List<Portfolio> GetPortfolio();
    public Portfolio GetPortfolioById(int id);
}