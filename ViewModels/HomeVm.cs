using WebApplication.Models;

namespace WebApplication.ViewModels;

public class HomeVm
{
    public List<Slider> Sliders { get; set; }
    public List<Feature> Features { get; set; }
    public List<Service> Services { get; set; }
    public List<Brand> Brands { get; set; }
}