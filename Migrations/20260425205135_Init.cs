using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portfolios_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortfolioImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfolioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PortfolioImages_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "clients-1.webp" },
                    { 2, "clients-2.webp" },
                    { 3, "clients-3.webp" },
                    { 4, "clients-4.webp" },
                    { 5, "clients-5.webp" },
                    { 6, "clients-6.webp" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Web Design" },
                    { 2, "Graphic Design" },
                    { 3, "Branding" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Description", "Icon", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "bi bi-bounding-box-circles icon", "Feature 1" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "bi bi-calendar4-week icon", "Feature 2" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "bi bi-broadcast icon", "Feature 3" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Icon", "Title" },
                values: new object[,]
                {
                    { 1, "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident", "bi bi-brightness-high", "Lorem Ipsum" },
                    { 2, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "bi bi-calendar4-week", "Sed ut perspiciatis" },
                    { 3, "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", "bi bi-binoculars", "Magni Dolores" },
                    { 4, "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque", "bi bi-bar-chart", "Nemo Enim" },
                    { 5, "Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur", "bi bi-card-checklist", "Dele cardo" },
                    { 6, "Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit asperiores", "bi bi-binoculars", "Divera don" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "ButtonLink", "ButtonText", "ImageUrl", "SubTitle", "Title" },
                values: new object[,]
                {
                    { 1, "#", "Learn More", "hero-carousel-1.jpg", "Hero carousel slide 1", "Slider 1" },
                    { 2, "#", "Learn More", "hero-carousel-2.jpg", "Hero carousel slide 2", "Slider 2" },
                    { 3, "#", "Learn More", "hero-carousel-3.jpg", "Hero carousel slide 3", "Slider 3" }
                });

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CategoryId", "Client", "Description", "ProjectDate", "ProjectUrl", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Client A", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project A", "App 1" },
                    { 2, 1, "Client B", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project B", "App 2" },
                    { 3, 1, "Client C", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project C", "App 3" }
                });

            migrationBuilder.InsertData(
                table: "PortfolioImages",
                columns: new[] { "Id", "ImageUrl", "PortfolioId" },
                values: new object[,]
                {
                    { 1, "portfolio-10.webp", 1 },
                    { 2, "portfolio-2.webp", 1 },
                    { 3, "portfolio-2.webp", 2 },
                    { 4, "portfolio-3.webp", 2 },
                    { 5, "portfolio-5.webp", 3 },
                    { 6, "portfolio-6.webp", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioImages_PortfolioId",
                table: "PortfolioImages",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_CategoryId",
                table: "Portfolios",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "PortfolioImages");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
