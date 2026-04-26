using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Models;

namespace WebApplication.Configuration;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.HasData(
            new Brand
            {
                Id = 1,
                ImageUrl = "clients-1.webp"
            },
            new Brand
            {
                Id = 2,
                ImageUrl = "clients-2.webp"
            },
            new Brand
            {
                Id = 3,
                ImageUrl = "clients-3.webp"
            },
            new Brand
            {
                Id = 4,
                ImageUrl = "clients-4.webp"
            },
            new Brand
            {
                Id = 5,
                ImageUrl = "clients-5.webp"
            },
            new Brand
            {
                Id = 6,
                ImageUrl = "clients-6.webp"
            });
        new Brand
        {
            Id = 7,
            ImageUrl = "clients-7.webp"
        };
    }
}