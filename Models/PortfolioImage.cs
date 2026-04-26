namespace WebApplication.Models;

public class PortfolioImage : BaseEntity
{
    public string ImageUrl { get; set; }
    public int PortfolioId { get; set; }
    public Portfolio Portfolio { get; set; }
}