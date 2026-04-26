using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Models;

namespace WebApplication.Configuration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category
            {
                Id = 1,
                Name = "Web Design"
            },
            new Category
            {
                Id = 2,
                Name = "Graphic Design"
            },
            new Category
            {
                Id = 3,
                Name = "Branding"
            });
        
    }
}