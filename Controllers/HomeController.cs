using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Data;
using WebApplication.Models;
using WebApplication.Services;
using WebApplication.ViewModels;

namespace WebApplication.Controllers;

public class HomeController(SliderService sliderService, FeatureService featureService, ServiceService serviceService, BrandService brandService) : Controller
{
    public IActionResult Index()
    {
        var vm = new HomeVm
        {
            Sliders = sliderService.GetSlider(),
            Features = featureService.GetFeature(),
            Brands = brandService.GetBrands(),
            Services = serviceService.GetServices()
                
        };

        return View(vm);
    }
    
}