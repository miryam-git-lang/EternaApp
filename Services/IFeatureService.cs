using WebApplication.Models;

namespace WebApplication.Services;

public interface IFeatureService
{
    public List<Feature> GetFeature();
}