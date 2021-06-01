using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaraVi.API.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    BestBefore = table.Column<DateTime>(maxLength: 10, nullable: false),
                    DateManifactured = table.Column<DateTime>(maxLength: 10, nullable: false),
                    Price = table.Column<double>(maxLength: 10, nullable: false),
                    Manifacturer = table.Column<string>(maxLength: 50, nullable: false),
                    Discription = table.Column<string>(maxLength: 1500, nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    Shipping = table.Column<string>(nullable: true),
                    PhotoURL = table.Column<string>(nullable: true),
                    SoldItems = table.Column<int>(nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    CountryOFOrigin = table.Column<string>(nullable: true),
                    Popularity = table.Column<bool>(nullable: false),
                    ByWeight = table.Column<bool>(nullable: false),
                    ByPeace = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
