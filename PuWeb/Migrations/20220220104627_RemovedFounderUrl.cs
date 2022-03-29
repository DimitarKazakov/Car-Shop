using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PuWeb.Migrations
{
    public partial class RemovedFounderUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FounderImageUrl",
                table: "CarMakes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FounderImageUrl",
                table: "CarMakes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
