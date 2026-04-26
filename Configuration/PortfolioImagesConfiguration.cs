using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Models;

namespace WebApplication.Configuration;

public class PortfolioImagesConfiguration : IEntityTypeConfiguration<PortfolioImage>
{
    public void Configure(EntityTypeBuilder<PortfolioImage> builder)
    {
        builder.HasData(
            new PortfolioImage
            {
                Id = 1,
                ImageUrl = "portfolio-10.webp",
                PortfolioId = 1
            },
            new PortfolioImage
            {
                Id = 2,
                ImageUrl = "portfolio-2.webp",
                PortfolioId = 1
            },
            new PortfolioImage
            {
                Id = 3,
                ImageUrl = "portfolio-2.webp",
                PortfolioId = 2
            },
            new PortfolioImage
            {
                Id = 4,
                ImageUrl = "portfolio-3.webp",
                PortfolioId = 2
            },
            new PortfolioImage
            {
                Id = 5,
                ImageUrl = "portfolio-5.webp",
                PortfolioId = 3
            },
            new PortfolioImage
            {
                Id = 6,
                ImageUrl = "portfolio-6.webp",
                PortfolioId = 3
            });
    }
}