using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Models;

namespace WebApplication.Configuration;

public class PortfolioConfiguration : IEntityTypeConfiguration<Portfolio>
{
    public void Configure(EntityTypeBuilder<Portfolio> builder)
    {
            builder.HasData(
                new Portfolio
                {
                    Id = 1,
                    Title = "App 1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ProjectDate = new DateTime(2023, 1, 1),
                    Client = "Client A",
                    ProjectUrl = "Project A", 
                    CategoryId = 1
                },
                new Portfolio
                {
                    Id = 2,
                    Title = "App 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ProjectDate = new DateTime(2023, 2, 1),
                    Client = "Client B",
                    ProjectUrl = "Project B", 
                    CategoryId = 1
                },
                new Portfolio
                {
                    Id = 3,
                    Title = "App 3",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ProjectDate = new DateTime(2023, 1, 5),
                    Client = "Client C",
                    ProjectUrl = "Project C", 
                    CategoryId = 1
                });
            
            new Portfolio()
            {
                Id = 4,
                Title = "App 4",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ProjectDate = new DateTime(2023, 3, 1),
                Client = "Client D",
                ProjectUrl = "Project D", 
                CategoryId = 2
            };

            new Portfolio()
            {
                Id = 5,
                Title = "App 5",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ProjectDate = new DateTime(2023, 4, 1),
                Client = "Client E",
                ProjectUrl = "Project E",
                CategoryId = 2
            };
            
            new Portfolio()
            {
                Id = 6,
                Title = "App 6",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ProjectDate = new DateTime(2023, 5, 1),
                Client = "Client F",
                ProjectUrl = "Project F", 
                CategoryId = 2
            };
    }

    
}
