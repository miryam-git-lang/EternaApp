using WebApplication.Models;

namespace WebApplication.ViewModels;

public class PortfolioVm
{
    public List<Portfolio> Portfolios { get; set; }
    public Portfolio Portfolio { get; set; }
    public List<Category> Categories { get; set; }
}