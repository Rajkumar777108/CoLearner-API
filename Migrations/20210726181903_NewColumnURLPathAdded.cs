using Microsoft.EntityFrameworkCore.Migrations;

namespace CoLearner.API.Migrations
{
    public partial class NewColumnURLPathAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlPath",
                table: "tblMstMenu",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlPath",
                table: "tblMstMenu");
        }
    }
}
