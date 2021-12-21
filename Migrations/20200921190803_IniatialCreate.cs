using Microsoft.EntityFrameworkCore.Migrations;

namespace CoLearner.API.Migrations
{
    public partial class IniatialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblMstMenu",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeqNbr = table.Column<int>(nullable: false),
                    MenuDesc = table.Column<string>(maxLength: 500, nullable: true),
                    CurrStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMstMenu", x => x.MenuId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblMstMenu");
        }
    }
}
