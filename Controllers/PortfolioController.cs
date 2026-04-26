using Microsoft.AspNetCore.Mvc;
using WebApplication.Services;
using WebApplication.ViewModels;

namespace WebApplication.Controllers;

public class PortfolioController(PortfolioService portfolioService, CategoryService categoryService) : Controller
{
    // GET
    public IActionResult Index()
    {
        PortfolioVm vm = new()
        {
            Portfolios = portfolioService.GetPortfolio(),
            Categories = categoryService.GetCategory()

        };
        return View(vm);
    }

    public IActionResult Detail(int id)
    {
        return View(id);   
    }

    public ActionResult GetDetail(int id)
    {
        var portfolio = portfolioService.GetPortfolioById(id);
        var result = new
        {
            portfolio.Id,
            portfolio.Title,
            portfolio.Description,
            portfolio.Client,
            portfolio.PortfolioImages,
            ProjectDate = portfolio.ProjectDate.ToString("dd/MM/yyyy"),
            Category = portfolio.Category,
            Images = portfolio.PortfolioImages.Select(pi => pi.ImageUrl).ToList()
        };
        
        return Json(result);
    }
}