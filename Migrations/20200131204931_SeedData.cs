using Microsoft.EntityFrameworkCore.Migrations;

namespace Park.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PublicParks",
                columns: new[] { "PublicParkId", "City", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Bar Harbor", "Acadia", "Maine" },
                    { 2, "Moab", "Arches", "Utah" },
                    { 3, "Rapid City", "Badlands", "Soulth Dakoda" },
                    { 4, "Alpine", "Big Bend", "Texas" },
                    { 5, "Klamath Falls", "Crater Lake", "Oregon" },
                    { 6, "Lone Pine", "Death Valley", "Nevada" },
                    { 7, "Healy", "Denali", "Alaska" },
                    { 8, "Coconino", "Grand Canyon", "Arizona" },
                    { 9, "Montezuma", "Mesa Verde", "Colorado" },
                    { 10, "Tacoma", "Mount Rainier", "Washington" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicParks",
                keyColumn: "PublicParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PublicParks",
                keyColumn: "PublicParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PublicParks",
                keyColumn: "PublicParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PublicParks",
                keyColumn: "PublicParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PublicParks",
                keyColumn: "PublicParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PublicParks",
                keyColumn: "PublicParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PublicParks",
                keyColumn: "PublicParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PublicParks",
                keyColumn: "PublicParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PublicParks",
                keyColumn: "PublicParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PublicParks",
                keyColumn: "PublicParkId",
                keyValue: 10);
        }
    }
}
