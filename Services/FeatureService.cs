using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services;

public class FeatureService(AppDbContext context): IFeatureService
{
    public List<Feature> GetFeature()
    {
        var features = context.Features.ToList();
        return features;
    }
}