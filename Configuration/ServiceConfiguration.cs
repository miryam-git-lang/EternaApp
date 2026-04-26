using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Models;

namespace WebApplication.Configuration;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.HasData(
            new Service
            {
                Id = 1,
                Icon = "bi bi-brightness-high",
                Title = "Lorem Ipsum",
                Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
            },
            new Service
            {
                Id = 2,
                Icon = "bi bi-calendar4-week",
                Title = "Sed ut perspiciatis",
                Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"
            },
            new Service
            {
                Id = 3,
                Icon = "bi bi-binoculars",
                Title = "Magni Dolores",
                Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
            },
            new Service
            {
                Id = 4,
                Icon = "bi bi-bar-chart",
                Title = "Nemo Enim",
                Description = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque"
            },
            new Service
            {
                Id = 5,
                Icon = "bi bi-card-checklist",
                Title = "Dele cardo",
                Description = "Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"
            },
            new Service
            {
                Id = 6,
                Icon = "bi bi-binoculars",
                Title = "Divera don",
                Description = "Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit asperiores"
            });
    }
}