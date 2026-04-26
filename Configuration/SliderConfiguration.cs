using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Models;

namespace WebApplication.Configuration;

public class SliderConfiguration : IEntityTypeConfiguration<Slider>
{
    public void Configure(EntityTypeBuilder<Slider> builder)
    {
        builder.HasData(
            new Slider
            {
                Id = 1,
                Title = "Slider 1",
                SubTitle = "Hero carousel slide 1",
                ButtonLink = "#",
                ButtonText = "Learn More",
                ImageUrl = "hero-carousel-1.jpg"
            },
            new Slider
            {
                Id = 2,
                Title = "Slider 2",
                SubTitle = "Hero carousel slide 2",
                ButtonLink = "#",
                ButtonText = "Learn More",
                ImageUrl = "hero-carousel-2.jpg"
            },
            new Slider
            {
                Id = 3,
                Title = "Slider 3",
                SubTitle = "Hero carousel slide 3",
                ButtonLink = "#",
                ButtonText = "Learn More",
                ImageUrl = "hero-carousel-3.jpg"
            });
    }
}