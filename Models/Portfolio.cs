namespace WebApplication.Models;

public class Portfolio : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<PortfolioImage> PortfolioImages { get; set; }
    public DateTime ProjectDate { get; set; } = DateTime.Now;
    public string Client { get; set; }
    public string ProjectUrl { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
    
}

