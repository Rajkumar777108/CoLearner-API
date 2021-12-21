using Microsoft.EntityFrameworkCore.Migrations;

namespace CoLearner.API.Migrations
{
    public partial class AddedDOBColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Users",
                newName: "DOB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "Users",
                newName: "MyProperty");
        }
    }
}
