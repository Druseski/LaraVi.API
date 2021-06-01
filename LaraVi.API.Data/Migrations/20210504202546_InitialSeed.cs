using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaraVi.API.Data.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Zacini" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BestBefore", "ByPeace", "ByWeight", "CategoryID", "CategoryName", "CountryOFOrigin", "DateAdded", "DateManifactured", "Discription", "Manifacturer", "Name", "PhotoURL", "Popularity", "Price", "Rating", "Shipping", "SoldItems", "UserID" },
                values: new object[] { 1, new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, 1, "Zacini", "Kurgistan", new DateTime(2021, 5, 4, 22, 25, 46, 385, DateTimeKind.Local).AddTicks(7653), new DateTime(2019, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nane moze da se upotrebuva i kako caj i kako zacin", "Po Doma", "Nane", "12x12x20", false, 198.0, 4.2999999999999998, "Koga ke mozam", 50, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
