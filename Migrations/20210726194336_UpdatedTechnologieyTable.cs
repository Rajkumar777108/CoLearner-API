using Microsoft.EntityFrameworkCore.Migrations;

namespace CoLearner.API.Migrations
{
    public partial class UpdatedTechnologieyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "tblTechnology");

            migrationBuilder.AddColumn<string>(
                name: "NavigationPath",
                table: "tblTechnology",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechName",
                table: "tblTechnology",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NavigationPath",
                table: "tblTechnology");

            migrationBuilder.DropColumn(
                name: "TechName",
                table: "tblTechnology");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "tblTechnology",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
