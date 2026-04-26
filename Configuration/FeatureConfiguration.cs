using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Models;

namespace WebApplication.Configuration;

public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        builder.HasData(
            new Feature
            {
                Id = 1,
                Title = "Feature 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Icon = "bi bi-bounding-box-circles icon"
            },
            new Feature
            {
                Id = 2,
                Title = "Feature 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Icon = "bi bi-calendar4-week icon"
            },
            new Feature
            {
                Id = 3,
                Title = "Feature 3",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Icon = "bi bi-broadcast icon"
            });
    }
}