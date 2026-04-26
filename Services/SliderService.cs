using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services;

public class SliderService(AppDbContext context) : ISliderService
{
    public List<Slider> GetSlider ()
    {
        var sliders = context.Sliders.ToList();
        return sliders; 
    }
}